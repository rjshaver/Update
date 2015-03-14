using System;
using System.Net;
using System.Threading;

namespace Update
{

   //new WebClient();				

   internal class Yahoodownloader
   {
	  private static String initurlstring = "http://ichart.finance.yahoo.com/table.csv?s=";
	  private static WebClient client = new WebClient();     // web client to download data from yahoo
	  private string symbol;
	  private Thread yahoothread;
	  private DateTime start;
	  private DateTime end;
	  private string urlstring;


	  public Yahoodownloader(string sym, DateTime begin, DateTime final)
	  {
		 symbol = sym;
		 start = begin;


		 end = final;
		 if (!symbol.StartsWith("^"))
		 {
			urlstring = initurlstring + symbol + "&a=";

			yahoothread = new Thread(new ThreadStart(yahooDownload));
			urlstring += start.Month.ToString();
			urlstring += "&b=" + start.Day.ToString();
			urlstring += "&c=" + start.Year.ToString();
			urlstring += "&d=" + end.Month.ToString();
			urlstring += "&e=" + end.Day.ToString() + "&f=";
			urlstring += end.Year.ToString() + "&g=d&ignore=.csv";
		 }
		 //  unless the symbol was an index indicated by starting the symbol with a ^
		 else
		 {
			urlstring = "http://finance.yahoo.com/q/hp?s=" + symbol + "+Historical+Prices";
		 }
		 yahoothread.Start();
	  }

	  private void yahooDownload()
	  {

		 DateTime yCurrentDate;
		 float yOpen, yHigh, yLow, yClose, yAdjClose;
		 Int64 yVolume;
		 // string selcmd;


		 if (start.CompareTo(end) <= 0)
		 {
			try
			{
			   //  get the data for a stock symbol from yahoo
			   //string csvfile = client.DownloadString(urlstring);
			   Uri urifrstr = new Uri(urlstring);
			   string csvfile =  (string)client.DownloadStringAsync(urifrstr);




			   //if (toReturn) return;
			}
			catch (WebException webEx)					 
			{
			   if (webEx.Status == WebExceptionStatus.ProtocolError)
			   {
				  outfile.WriteLine(symbol);
				  outfile.Flush();
				  Console.WriteLine("File not available :" + symbol);
			   }
			   else
			   {
				  Console.WriteLine("{0}", webEx.StackTrace);

				  Console.WriteLine("Status is: {0}", webEx.Status);

				  if (webEx.Status == WebExceptionStatus.ConnectFailure)
				  {
					 Console.WriteLine("Are you behind a firewall?  If so, go through the proxy server.");
					 if (toReturn) return;
				  }
			   }
			}
			catch (ArgumentNullException argEx)
			{
			   Console.WriteLine("Did you forget to initialize the url:{0}\nException is: {1}", urlstring, argEx.ToString());
			   if (toReturn) return;
			}
			catch (NotSupportedException nsEx)
			{
			   Console.WriteLine("Not Supported Exception : {0}", nsEx.ToString());
			   if (toReturn) return;
			}
			catch (Exception exc)
			{
			   Console.WriteLine("Exception type: {0}, Stack Trace = {1}", exc.GetType(), exc.StackTrace);
			   Console.WriteLine("{0} : {1}", line, symbol);
			   if (toReturn) return;
			}
		 }
	  }

   }
}