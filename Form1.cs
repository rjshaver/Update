// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Form1.cs" company="Randy">
//           2014
// </copyright>
// <summary>
//   The form 1.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Update
{
   using System;
   using System.Data.SqlClient;
   using System.IO;
   using System.Data;
   using System.Net;
   using System.Windows.Forms;
   using System.Collections.Concurrent;
   using System.Threading.Tasks;
   using System.Collections;

   /// <summary>
   /// The form 1.
   /// </summary>
   public partial class UpdateForm : Form
   {
	  /// <summary>
	  /// The result   is a DateTime object that holds the latest update date of the data in the stocks database
	  /// </summary>
	  private DateTime result;

	  private DateTime lastOpenDate;	 // last day the stock market was open based on today
	  private int stockrowcount;

	  //  connection string for SQL Server on local machine LENEVO
	  private const string ConString = "Data Source=LENEVO\\SQLEXPRESS;Initial Catalog=Stocks;Integrated Security=True";
	  string filename = "C:\\Users\\Randy\\Documents\\StockLogs\\StockNotFound.txt";		   // error file for no stock data at yahoo

	  //  start of the url string to download stock data
	  private static String initurlstring = "http://ichart.finance.yahoo.com/table.csv?s=";

	  //private WebClient client;				  // web client to download data from yahoo

	  #region Constructors and Destructors

	  /// <summary>
	  /// Initializes a new instance of the <see cref="UpdateForm"/> class.
	  /// </summary>
	  public UpdateForm()
	  {
		 this.InitializeComponent();
	  }

	  #endregion Constructors and Destructors

	  #region Methods

	  // / <summary>
	  // / The form 1_ load.  The main load method for the main form of the program
	  // / </summary>
	  // / <param name="sender">
	  // / The sender.      default sender
	  // / </param>
	  // / <param name="e">
	  // / The e.
	  // / </param>
	  private void Form1_Load(object sender, EventArgs e)
	  {
		 // TODO: This line of code loads data into the 'removeStocksDataSet.DELSTOCKLIST' table. You can move, or remove it, as needed.
		 this.dELSTOCKLISTTableAdapter.Fill(this.removeStocksDataSet.DELSTOCKLIST);
		 this.textBoxTodaysDate.Text = DateTime.Today.ToString("MMM d, yyyy");

		 try
		 {
			using (var con = new SqlConnection(ConString))
			using (var cmd = new SqlCommand("SELECT MAX(RECENTDATE) AS RECDATE FROM   ALLSTOCKLIST", con))
			{
			   con.Open();
			   this.result = new DateTime();
			   this.result = (DateTime)cmd.ExecuteScalar();
			   this.textBoxRecentDate.Text = this.result.ToString("MMM d, yyyy");
			}
		 }
		 catch (SqlException ex)
		 {
			MessageBox.Show(ex.ToString()); // do you get any Exception here?
		 }
		 LastOpenExchangeDate lastOpenD = new LastOpenExchangeDate(DateTime.Now);
		 lastOpenDate = lastOpenD.Lastopen;

		 if (deleteComboBox.Text != "")
		 {
			textBox1.Text = ((DateTime)allstocklistTableAdapter1.GetRecentDateBySymbol(deleteComboBox.Text)).ToString("MMM dd, yyyy");

		 }
	  }
		 
	  #endregion Methods

	  private void updateButton_Click(object sender, EventArgs e)
	  {
		 SetUpdateButton(false);
		 Task task = new Task(new Action(UpdateDBasewithYahoo));
		 task.Start();


		 


	
	  }

	  private void UpdateDBasewithYahoo()
	  {
		 DateTime start = DateTime.Now;
		 //statusTextBox.AppendText("Started updating the database at " + start.ToString() + "\n");

		 AppendStatusBox("Started updating the database at " + start.ToString() + "\n");
		 DateTime yCurrentDate = DateTime.Today;			// current daate of data from yahoo
		 

		 BlockingCollection<stockinfo> symbolLastDate = new BlockingCollection<stockinfo>();
		 BlockingCollection<stockdownloaded> downloadData = new BlockingCollection<stockdownloaded>();
		 BlockingCollection<toDatabase> databaseStockData = new BlockingCollection<toDatabase>();


		 AppendStatusBox("Starting tasks \n");
		 //Console.WriteLine("Starting tasks \n");

		 //  open error file for no stock data at yahoo

		 


		 var f = new TaskFactory(TaskCreationOptions.LongRunning, TaskContinuationOptions.None);
		 // ...
		 var loadSymbolTask = f.StartNew(() => GenerateSymbolandDate(symbolLastDate));
		 var downloadDataTask = f.StartNew(() => YahooDownload(symbolLastDate, downloadData));
		 var generateStrings = f.StartNew(() => GenerateStringstoDatabase(downloadData, databaseStockData));
		 var loadDataTask = f.StartNew(() => UpdateDatabase(databaseStockData));

		 Task.WaitAll(loadSymbolTask, downloadDataTask, generateStrings, loadDataTask);
		 DateTime ended = DateTime.Now;
		 TimeSpan totaltime = ended - start;
		 //statusTextBox.AppendText("Update operation completed in: " + totaltime.ToString() + "\n");

		 string correctlinesofdata = "USE [Stocks] UPDATE [dbo].[ALLSTOCKLIST] SET [LINESOFDATA] =  (SELECT COUNT(*) FROM [dbo].[ALLSTOCKDATA] WHERE [dbo].[ALLSTOCKDATA].[SYMBOL]=[dbo].[ALLSTOCKLIST].[SYMBOL])";
		 using (var con5 = new SqlConnection(ConString))
		 using (var cmd5 = new SqlCommand(correctlinesofdata, con5))
		 {
			//  open the db
			con5.Open();
			try
			{
			   cmd5.ExecuteNonQuery();
			  

			}
			catch (SqlException sex)
			{
			   Console.WriteLine("SQL exception on command: {0}", correctlinesofdata);
			   Console.WriteLine(sex.StackTrace);
			}


		 }






		 AppendStatusBox("Update operation completed in: " + totaltime.ToString() + "\n");
		 SetUpdateButton(true);
		 //dELSTOCKLISTTableAdapter.GetData();
		// this.dELSTOCKLISTTableAdapter.Fill(this.removeStocksDataSet.DELSTOCKLIST);
		 //dELSTOCKLISTTableAdapter.Fill(removeStocksDataSet.DELSTOCKLIST);
		 //dELSTOCKLISTBindingSource.ResetBindings(false);
		 //deleteComboBox.Invalidate();
		 //deleteComboBox.Refresh();
		 
		 //dELSTOCKLISTTableAdapter.Fill(removeStocksDataSet.DELSTOCKLIST);
		 //deleteComboBox.DataSource = null;
		 //deleteComboBox.DataSource = removeStocksDataSet.DELSTOCKLIST;

		 //deleteComboBox.Refresh();
		 //deleteComboBox.Invalidate();
	  }

	  

	  private void UpdateDatabase(BlockingCollection<toDatabase> input)
	  {
		// throw new NotImplementedException();
		 foreach (var item in input.GetConsumingEnumerable())

		 {

			int count = 0;
			while (item.DBaseStrings.Count > 0)
			{  
			   string update = (string)item.DBaseStrings.Pop();
			   using (var con = new SqlConnection(ConString))
			   using (var cmd = new SqlCommand(update, con))
			   {
				  //  open the db
				  con.Open();
				  try
				  {
					 cmd.ExecuteNonQuery();
					 count++;

				  }
				  catch (SqlException sex)
				  {
					 Console.WriteLine("SQL exception on command: {0}", update);
					 Console.WriteLine(sex.StackTrace);
				  }


			   }
			}

			

			string updaterecdate = "UPDATE [dbo].[ALLSTOCKLIST] SET RECENTDATE = '" + item.NewRecentDate.ToString("MM-dd-yyyy") + "' WHERE SYMBOL = '" +
				   item.MyStockSymbol + "'";
			using (var con1 = new SqlConnection(ConString))
			using (var cmd1 = new SqlCommand(updaterecdate, con1))
			{
			   //  open the db
			   con1.Open();
			   try
			   {
				  cmd1.ExecuteNonQuery();

			   }
			   catch (SqlException sex)
			   {
				  Console.WriteLine("SQL exception on command: {0}", updaterecdate);
				  Console.WriteLine(sex.StackTrace);
			   }
			}

			SetUpdateDBProgressBar(item.Number);
			SetUpdateDBProgressPercentageLabel(item.Number);
			SetUpdateDBTextBox(item.MyStockSymbol);
			//AppendStatusBox(item.Number + ": Changed database for: " + item.MyStockSymbol + " with " + count + " lines\n");
			//Console.WriteLine(item.Number + ": Changed database for: " + item.MyStockSymbol + " with " + count +" lines\n");

		 }
		 SetUpdateDBTextBox("DONE");
		 //dELSTOCKLISTTableAdapter.Fill(removeStocksDataSet.DELSTOCKLIST);
	  }

	  private void GenerateStringstoDatabase(BlockingCollection<stockdownloaded> input, BlockingCollection<toDatabase> output)
	  {
		// throw new NotImplementedException();
		 string[] lines;
		 string line;
		 DateTime yCurrentDate, newrecdate;
		 float yOpen, yHigh, yLow, yClose, yAdjClose;
		 Int64 yVolume;
		 //int count = 0;

		 foreach (var item in input.GetConsumingEnumerable())
		 {
		
			Stack updatestrings = new Stack();
			lines = item.Data.Split('\n');
			newrecdate = item.NewLastUpdate;
		 

			for (int j = 1; j < lines.Length; j++)
			{
			   //statusTextBox.AppendText("\n");
			   //statusTextBox.AppendText(line);
			   line = lines[j];
			   if (line.Length > 0)
			   {
				  string[] items = line.Split(',');
				  yCurrentDate = DateTime.Parse(items[0]);
				  yOpen = float.Parse(items[1]);
				  yHigh = float.Parse(items[2]);
				  yLow = float.Parse(items[3]);
				  yClose = float.Parse(items[4]);
				  yVolume = Int64.Parse(items[5]);
				  yAdjClose = float.Parse(items[6]);

				  //TODO insert or update into allstockdata
				  string insupdstring = "USE [STOCKS] UPDATE [dbo].[ALLSTOCKDATA] SET SYMBOL = '" + item.StockSymbol + "',SDATE = '" +
					 yCurrentDate.ToString("MM-dd-yyyy") + "', SOPEN = " + yOpen.ToString() +  ", SHIGH = "+ yHigh.ToString() +
					 ", SLOW = " + yLow.ToString() + ", SCLOSE = " + yClose.ToString() + ", SVOLUME = " + yVolume.ToString() +
					 ", SADJCLOSE = " + yAdjClose.ToString() +  " WHERE (SYMBOL ='" + item.StockSymbol + "'  AND SDATE ='" + 
					 yCurrentDate.ToString("MM-dd-yyyy") + "') ";
				  insupdstring += " IF @@ROWCOUNT=0  INSERT INTO [dbo].[ALLSTOCKDATA] (SYMBOL,SDATE,SOPEN,SHIGH,SLOW,SCLOSE,SVOLUME,SADJCLOSE) VALUES ('"+
					 item.StockSymbol + "', '" + yCurrentDate.ToString("MM-dd-yyyy") + "', "  + yOpen.ToString() + ", " +
					 yHigh.ToString() +", " + yLow.ToString() + ", " + yClose.ToString() + ", " + yVolume.ToString() + ", " +
					 yAdjClose.ToString() + ")";






				  if (yCurrentDate > newrecdate) { newrecdate = yCurrentDate; }
				  
				  updatestrings.Push(insupdstring);
			   }

			
			}
			

			   //statusTextBox.AppendText(item.Number + ": Generated Sql statements for " + item.StockSymbol + "\n");
			   //AppendStatusBox(item.Number + ": Generated Sql statements for " + item.StockSymbol + "\n");
			   //Console.WriteLine(item.Number + ": Generated Sql statements for " + item.StockSymbol + "\n");
			
			   	

				output.Add(new toDatabase(item.Number,  item.StockSymbol,newrecdate, updatestrings));
				SetGenerateSQLProgressBar(item.Number);
				SetGenerateSQLProgressPercentageLabel(item.Number);
				SetGenerateSQLTextBox(item.StockSymbol);
			}

		 output.CompleteAdding();
		 SetGenerateSQLTextBox("DONE");		   
		 



	  }

	  private void YahooDownload(BlockingCollection<stockinfo> input, BlockingCollection<stockdownloaded> output)
	  {
		 //throw new NotImplementedException();
		 string urlstring;
		 WebClient client = new WebClient();
		 StreamWriter outfile = new StreamWriter(filename, true);
		 foreach (var item in input.GetConsumingEnumerable())
		 {

			if (!item.Symbol.StartsWith("^"))
			{
			   urlstring = initurlstring + item.Symbol + "&a=";
			   urlstring += (item.LastUpdate.Month-1).ToString();
			   urlstring += "&b=" + item.LastUpdate.Day.ToString();
			   urlstring += "&c=" + item.LastUpdate.Year.ToString();
			   urlstring += "&d=" + (lastOpenDate.Month-1).ToString();
			   urlstring += "&e=" + lastOpenDate.Day.ToString() + "&f=";
			   urlstring += lastOpenDate.Year.ToString() + "&g=d&ignore=.csv";
			}
			//  unless the symbol was an index indicated by starting the symbol with a ^
			else
			{
			   urlstring = "http://finance.yahoo.com/q/hp?s=" + item.Symbol + "+Historical+Prices";
			}

			
			if (item.LastUpdate.CompareTo(lastOpenDate) <= 0)
			{
			   //  get the data for a stock symbol from yahoo
			   try
			   {
				  string csvfile = client.DownloadString(urlstring);
				  if (csvfile != null || csvfile != "")
				  {
					 output.Add(new stockdownloaded(item.Symbol, item.LastUpdate, csvfile, item.Number));
					 //statusTextBox.AppendText(item.Number + ": Downloaded from yahoo for " + item.Symbol + "\n");
					 SetDownloadProgressBar(item.Number);
					 SetDownloadProgressPercentageLabel(item.Number);
					 SetDownloadTextBox(item.Symbol);
					 //Console.WriteLine(item.Number + ": Downloaded from yahoo for " + item.Symbol + "\n");
					 //AppendStatusBox(item.Number + ": Downloaded from yahoo for " + item.Symbol + "\n");
				  }
				  
			   }																							  
			   catch (WebException webEx)
			   {
				  if (webEx.Status == WebExceptionStatus.ProtocolError)
				  {
					 outfile.WriteLine(item.Symbol);
					 outfile.Flush();
					 Console.WriteLine("{0}:  File not available : {1}" ,item.Number, item.Symbol);
					 //TODO try to put symbol in database of DELSTOCKLIST
					 TimeSpan interval = lastOpenDate - item.LastUpdate;
					 if (interval.Days > 60)
					 {
						InsertDelStockListTableAdapter(item.Symbol);
						if (deleteComboBox.Text != "")
						{
						   textBox1.Text = ((DateTime)allstocklistTableAdapter1.GetRecentDateBySymbol(deleteComboBox.Text)).ToString("MMM dd, yyyy");

						}
					 }
					 
					
				  }
				  else
				  {
					 Console.WriteLine("{0}", webEx.StackTrace);

					 Console.WriteLine("Status is: {0}", webEx.Status);

					 if (webEx.Status == WebExceptionStatus.ConnectFailure)
					 {
						Console.WriteLine("Are you behind a firewall?  If so, go through the proxy server.");
						//if (toReturn) return;
					 }
				  }
			   }
						   
			   
			   
			}




		  }
		 output.CompleteAdding();
		 SetDownloadTextBox("DONE");

	  }

	  private void InsertDelStockListTableAdapter(string p)
	  {
		 //throw new NotImplementedException();
		 if (deleteComboBox.InvokeRequired)
		 {
			deleteComboBox.Invoke(new Action<string>(InsertDelStockListTableAdapter),p);
			return;
		 }

		 try
		 {
			dELSTOCKLISTTableAdapter.Insert(p);
		 }
		 catch (SqlException ex)
		 {
			Console.WriteLine(ex.StackTrace + "\n Failed to load into delstocklist: " + p);
		 }
		 finally
		 {
			dELSTOCKLISTTableAdapter.Fill(removeStocksDataSet.DELSTOCKLIST);	
		 }
		 
					
	  }

	 

	  private void GenerateSymbolandDate(BlockingCollection<stockinfo> output1)
	  {
		 string symbol = null;
		 int count = 1;
		 DateTime symbolRecDate = DateTime.Now  ;
		 try
		 {
			//    open db and get each symbol and it's most recent update date
			using (var con = new SqlConnection(ConString))
			using (var cmd = new SqlCommand("SELECT SYMBOL,RECENTDATE FROM   ALLSTOCKLIST order by SYMBOL", con))
			{
			   //  open the db
			   con.Open();
			   //  get the data into a reader
			   using (var cmd1 = new SqlCommand("SELECT COUNT(*) FROM ALLSTOCKLIST",con) )
			   {
				  stockrowcount = (int)cmd1.ExecuteScalar();
			   }
			   using (SqlDataReader reader = cmd.ExecuteReader())
			   {
				  // check to see if sql select statement returned any rows
				  if (reader.HasRows)

				  {
					 
					 InitializeReadSymbolProgressBar(stockrowcount);
					 InitializeDownloadProgressBar(stockrowcount);
					 InitializeGenerateSQLProgressBar(stockrowcount);
					 InitializeUpdateDBProgressBar(stockrowcount);
					 //  read each row, symbol and recent date
					 while (reader.Read())
					 {
						// Get symbol and recentdate
						symbol = reader.GetString(0);
						symbolRecDate = reader.GetDateTime(1);
						// set the recent date to a new value, updating as more data is downloaded
						DateTime newrecdate = new DateTime(symbolRecDate.Year, symbolRecDate.Month, symbolRecDate.Day);
						// todo for each stock download data from yahoo
						output1.Add(new stockinfo(symbol, newrecdate, count++));

						SetReadSymbolProgressBar(count - 1);
						SetReadSymbolProgressPercentageLabel(count - 1);
						SetReadSymbolTextBox(symbol);
						//Console.WriteLine(count + ": Generated stockinfo for " + symbol + " starting on " + newrecdate.ToString() + "\n");
						//AppendStatusBox(count + ": Generated stockinfo for " + symbol + " starting on " + newrecdate.ToString() + "\n");
					 }
				  }
			   }
			}
			output1.CompleteAdding();
			SetReadSymbolTextBox("DONE");
		 }
		 catch (SqlException ex)
		 {
			MessageBox.Show(ex.ToString()); // do you get any Exception here?
		 }
	  }

	  private void AppendStatusBox(string msg)
	  {																			   
		 if (  statusTextBox.InvokeRequired)
		 {
			statusTextBox.Invoke(new Action<string>(AppendStatusBox),msg );
			//StatusLabel.Invoke(new Action<string>(UpdateStatusLabel), msg);
			return;
		 }
		 statusTextBox.AppendText(msg);

	  }


	  private void SetReadSymbolTextBox(string msg)
	  {
		 if (readSymboltextBox.InvokeRequired)
		 {
			readSymboltextBox.Invoke(new Action<string>(SetReadSymbolTextBox), msg);
			return;
		 }
		 readSymboltextBox.Text = msg;
	  }



	  private void InitializeReadSymbolProgressBar(int i)
	  {
		 if (readSymbolprogressBar.InvokeRequired)
		 {
			readSymbolprogressBar.Invoke(new Action<int>(InitializeReadSymbolProgressBar), i);
			return;
		 }
		 readSymbolprogressBar.Maximum = i;
		 readSymbolprogressBar.Value = 0;
	  }

	  private void SetReadSymbolProgressBar(int i)
	  {
		 if (readSymbolprogressBar.InvokeRequired)
		 {
			readSymbolprogressBar.Invoke(new Action<int>(SetReadSymbolProgressBar), i);
			return;
		 }
		 
		 readSymbolprogressBar.Value = i;
		 
	  }

	  private void SetReadSymbolProgressPercentageLabel(int i)
	  {
		 if (ReadSymbolPercentagelabel.InvokeRequired)
		 {
			ReadSymbolPercentagelabel.Invoke(new Action<int>(SetReadSymbolProgressPercentageLabel), i);
			return;
		 }
		 ReadSymbolPercentagelabel.Text = ((int)(i * 100 /readSymbolprogressBar.Maximum)).ToString() + " %";
	  }
	  



	  


	  private void SetDownloadTextBox(string msg)
	  {
		 if (DownloadtextBox.InvokeRequired)
		 {
			DownloadtextBox.Invoke(new Action<string>(SetDownloadTextBox), msg);
			return;
		 }
		 DownloadtextBox.Text = msg;
	  }

	  private void InitializeDownloadProgressBar(int i)
	  {
		 if (downloadprogressBar.InvokeRequired)
		 {
			downloadprogressBar.Invoke(new Action<int>(InitializeDownloadProgressBar), i);
			return;
		 }
		 downloadprogressBar.Maximum = i;
		 downloadprogressBar.Value = 0;
	  }

	  private void SetDownloadProgressBar(int i)
	  {
		 if (downloadprogressBar.InvokeRequired)
		 {
			downloadprogressBar.Invoke(new Action<int>(SetDownloadProgressBar), i);
			return;
		 }

		 downloadprogressBar.Value = i;

	  }

	  private void SetDownloadProgressPercentageLabel(int i)
	  {
		 if (downloadProgressPercentagelabel.InvokeRequired)
		 {
			downloadProgressPercentagelabel.Invoke(new Action<int>(SetDownloadProgressPercentageLabel), i);
			return;
		 }
		 downloadProgressPercentagelabel.Text = ((int)(i * 100/downloadprogressBar.Maximum)).ToString() + " %";
	  }
	  



	  private void SetGenerateSQLTextBox(string msg)
	  {
		 if (generateSQLtextBox.InvokeRequired)
		 {
			generateSQLtextBox.Invoke(new Action<string>(SetGenerateSQLTextBox), msg);
			return;
		 }
		 generateSQLtextBox.Text = msg;
	  }



	  private void InitializeGenerateSQLProgressBar(int i)
	  {
		 if (generateSQLprogressBar.InvokeRequired)
		 {
			generateSQLprogressBar.Invoke(new Action<int>(InitializeGenerateSQLProgressBar), i);
			return;
		 }
		 generateSQLprogressBar.Maximum = i;
		 generateSQLprogressBar.Value = 0;
	  }

	  private void SetGenerateSQLProgressBar(int i)
	  {
		 if (generateSQLprogressBar.InvokeRequired)
		 {
			generateSQLprogressBar.Invoke(new Action<int>(SetGenerateSQLProgressBar), i);
			return;
		 }

		 generateSQLprogressBar.Value = i;

	  }

	  private void SetGenerateSQLProgressPercentageLabel(int i)
	  {
		 if (GenerateSQLPercentageLabel.InvokeRequired)
		 {
			GenerateSQLPercentageLabel.Invoke(new Action<int>(SetGenerateSQLProgressPercentageLabel), i);
			return;
		 }
		 GenerateSQLPercentageLabel.Text = ((int)(i * 100/generateSQLprogressBar.Maximum)).ToString() + " %";
	  }
	  








	  private void SetUpdateDBTextBox(string msg)
	  {

		 if (updateDBtextBox.InvokeRequired)
		 {
			updateDBtextBox.Invoke(new Action<string>(SetUpdateDBTextBox), msg);
			return;
		 }
		 updateDBtextBox.Text = msg;
	  }

	  private void InitializeUpdateDBProgressBar(int i)
	  {
		 if (updateDBprogressBar.InvokeRequired)
		 {
			updateDBprogressBar.Invoke(new Action<int>(InitializeUpdateDBProgressBar), i);
			return;
		 }
		 updateDBprogressBar.Maximum = i;
		 updateDBprogressBar.Value = 0;
	  }

	  private void SetUpdateDBProgressBar(int i)
	  {
		 if (updateDBprogressBar.InvokeRequired)
		 {
			updateDBprogressBar.Invoke(new Action<int>(SetUpdateDBProgressBar), i);
			return;
		 }

		 updateDBprogressBar.Value = i;

	  }

	  private void SetUpdateDBProgressPercentageLabel(int i)
	  {
		 if (updateDBProgressPercentageLabel.InvokeRequired)
		 {
			updateDBProgressPercentageLabel.Invoke(new Action<int>(SetUpdateDBProgressPercentageLabel), i);
			return;
		 }
		 updateDBProgressPercentageLabel.Text = ((int)(i * 100 / updateDBprogressBar.Maximum)).ToString() + " %";
	  }
	  


	 

	  
	

	  private void SetUpdateButton(bool p)
	  {
		 
		// throw new NotImplementedException();
		 if (button1.InvokeRequired)
		 {
			button1.Invoke(new Action<bool>(SetUpdateButton),p);
			return;

		 }
		 button1.Enabled = p;
	  }

	

	  private void RemoveDatabutton_Click(object sender, EventArgs e)
	  {
		 string sym = (string)deleteComboBox.SelectedValue;
		 AppendStatusBox(sym + "\n");

		 string insert1 = "USE [Stocks] INSERT INTO [dbo].[OLDSTOCKDATA]  SELECT * FROM [dbo].ALLSTOCKDATA WHERE SYMBOL = '" + sym + "'";
		 string insert2 = "USE [Stocks]	INSERT INTO [dbo].[OLDSTOCKLIST]  SELECT * FROM [dbo].ALLSTOCKLIST WHERE SYMBOL = '" + sym + "'";
		 string delete1 = "USE [Stocks]	DELETE FROM [dbo].[ALLSTOCKDATA] WHERE SYMBOL = '" + sym + "'";
		 string delete2 = "USE [Stocks]	DELETE FROM [dbo].[ALLSTOCKLIST] WHERE SYMBOL = '" + sym + "'";


		 using (var con1 = new SqlConnection(ConString))
		 using (var cmd1 = new SqlCommand(insert1, con1))
		 {
			//  open the db
			con1.Open();

			try
			{
			   cmd1.ExecuteNonQuery();
			   
			}
			catch (SqlException sex)
			{
			   Console.WriteLine("SQL exception on command: {0}", insert1);
			   Console.WriteLine(sex.StackTrace);
			}
		 }

			using (var con2 = new SqlConnection(ConString))
		 using (var cmd2 = new SqlCommand(insert2, con2))
		 {
			//  open the db
			con2.Open();

			try
			{
			   cmd2.ExecuteNonQuery();
			   

			}
			catch (SqlException sex)
			{
			   Console.WriteLine("SQL exception on command: {0}", insert2);
			   Console.WriteLine(sex.StackTrace);
			}

		 }
			   
			using (var con3 = new SqlConnection(ConString))
			using (var cmd3 = new SqlCommand(delete1, con3))
			{
			   //  open the db
			   con3.Open();

			   try
			   {
				  cmd3.ExecuteNonQuery();


			   }
			   catch (SqlException sex)
			   {
				  Console.WriteLine("SQL exception on command: {0}", delete1);
				  Console.WriteLine(sex.StackTrace);
			   }

			}


			using (var con4 = new SqlConnection(ConString))
			using (var cmd4 = new SqlCommand(delete2, con4))
			{
			   //  open the db
			   con4.Open();

			   try
			   {
				  cmd4.ExecuteNonQuery();


			   }
			   catch (SqlException sex)
			   {
				  Console.WriteLine("SQL exception on command: {0}", delete1);
				  Console.WriteLine(sex.StackTrace);
			   }

			}	  

			 dELSTOCKLISTTableAdapter.Delete(sym);
			 dELSTOCKLISTTableAdapter.Fill(removeStocksDataSet.DELSTOCKLIST);
			 //this.dELSTOCKLISTTableAdapter.Fill(this.removeStocksDataSet.DELSTOCKLIST);
			 //deleteComboBox.Items.Remove(deleteComboBox.SelectedItem);
			// dELSTOCKLISTBindingSource.ResetBindings(true);


	  }

	  private void button2_Click(object sender, EventArgs e)
	  {

		 InsertForm nf = new InsertForm(this);
		 nf.Show();
		 this.Hide();
	  }

	  private void deleteComboBox_SelectedIndexChanged(object sender, EventArgs e)
	  {
		 if (deleteComboBox.Text != "")
		 {

			textBox1.Text = ((DateTime)allstocklistTableAdapter1.GetRecentDateBySymbol(deleteComboBox.Text)).ToString("MMM dd, yyyy");	
		 }
		 else
		 {
			textBox1.Text = "";
		 }
		 
	  }

	
   }
}									 