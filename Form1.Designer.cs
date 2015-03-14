namespace Update
{
	/// <summary>
	/// The main Form for the program
	/// </summary>
	partial class UpdateForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
		 this.components = new System.ComponentModel.Container();
		 this.label1 = new System.Windows.Forms.Label();
		 this.textBoxTodaysDate = new System.Windows.Forms.TextBox();
		 this.label2 = new System.Windows.Forms.Label();
		 this.textBoxRecentDate = new System.Windows.Forms.TextBox();
		 this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
		 this.stocksDataSet = new Update.StocksDataSet();
		 this.allstocklistTableAdapter1 = new Update.StocksDataSetTableAdapters.ALLSTOCKLISTTableAdapter();
		 this.allstockdataTableAdapter1 = new Update.StocksDataSetTableAdapters.ALLSTOCKDATATableAdapter();
		 this.statusTextBox = new System.Windows.Forms.TextBox();
		 this.button1 = new System.Windows.Forms.Button();
		 this.readSymbolprogressBar = new System.Windows.Forms.ProgressBar();
		 this.downloadprogressBar = new System.Windows.Forms.ProgressBar();
		 this.generateSQLprogressBar = new System.Windows.Forms.ProgressBar();
		 this.updateDBprogressBar = new System.Windows.Forms.ProgressBar();
		 this.readSymboltextBox = new System.Windows.Forms.TextBox();
		 this.DownloadtextBox = new System.Windows.Forms.TextBox();
		 this.generateSQLtextBox = new System.Windows.Forms.TextBox();
		 this.updateDBtextBox = new System.Windows.Forms.TextBox();
		 this.deleteComboBox = new System.Windows.Forms.ComboBox();
		 this.dELSTOCKLISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
		 this.removeStocksDataSet = new Update.RemoveStocksDataSet();
		 this.RemoveDatabutton = new System.Windows.Forms.Button();
		 this.dELSTOCKLISTTableAdapter = new Update.RemoveStocksDataSetTableAdapters.DELSTOCKLISTTableAdapter();
		 this.label3 = new System.Windows.Forms.Label();
		 this.label4 = new System.Windows.Forms.Label();
		 this.label5 = new System.Windows.Forms.Label();
		 this.label6 = new System.Windows.Forms.Label();
		 this.ReadSymbolPercentagelabel = new System.Windows.Forms.Label();
		 this.downloadProgressPercentagelabel = new System.Windows.Forms.Label();
		 this.GenerateSQLPercentageLabel = new System.Windows.Forms.Label();
		 this.updateDBProgressPercentageLabel = new System.Windows.Forms.Label();
		 this.button2 = new System.Windows.Forms.Button();
		 this.textBox1 = new System.Windows.Forms.TextBox();
		 this.aLLSTOCKLISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
		 this.aLLSTOCKLISTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
		 ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
		 ((System.ComponentModel.ISupportInitialize)(this.stocksDataSet)).BeginInit();
		 ((System.ComponentModel.ISupportInitialize)(this.dELSTOCKLISTBindingSource)).BeginInit();
		 ((System.ComponentModel.ISupportInitialize)(this.removeStocksDataSet)).BeginInit();
		 ((System.ComponentModel.ISupportInitialize)(this.aLLSTOCKLISTBindingSource)).BeginInit();
		 ((System.ComponentModel.ISupportInitialize)(this.aLLSTOCKLISTBindingSource1)).BeginInit();
		 this.SuspendLayout();
		 // 
		 // label1
		 // 
		 this.label1.AutoSize = true;
		 this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		 this.label1.Location = new System.Drawing.Point(30, 28);
		 this.label1.Name = "label1";
		 this.label1.Size = new System.Drawing.Size(158, 29);
		 this.label1.TabIndex = 0;
		 this.label1.Text = "Today\'s Date:";
		 // 
		 // textBoxTodaysDate
		 // 
		 this.textBoxTodaysDate.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		 this.textBoxTodaysDate.Location = new System.Drawing.Point(194, 25);
		 this.textBoxTodaysDate.Name = "textBoxTodaysDate";
		 this.textBoxTodaysDate.ReadOnly = true;
		 this.textBoxTodaysDate.Size = new System.Drawing.Size(205, 35);
		 this.textBoxTodaysDate.TabIndex = 1;
		 // 
		 // label2
		 // 
		 this.label2.AutoSize = true;
		 this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		 this.label2.Location = new System.Drawing.Point(424, 28);
		 this.label2.Name = "label2";
		 this.label2.Size = new System.Drawing.Size(262, 29);
		 this.label2.TabIndex = 2;
		 this.label2.Text = "Recent Date of Update:";
		 // 
		 // textBoxRecentDate
		 // 
		 this.textBoxRecentDate.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		 this.textBoxRecentDate.Location = new System.Drawing.Point(692, 25);
		 this.textBoxRecentDate.Name = "textBoxRecentDate";
		 this.textBoxRecentDate.ReadOnly = true;
		 this.textBoxRecentDate.Size = new System.Drawing.Size(197, 35);
		 this.textBoxRecentDate.TabIndex = 3;
		 // 
		 // bindingSource1
		 // 
		 this.bindingSource1.DataSource = this.stocksDataSet;
		 this.bindingSource1.Position = 0;
		 // 
		 // stocksDataSet
		 // 
		 this.stocksDataSet.DataSetName = "StocksDataSet";
		 this.stocksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
		 // 
		 // allstocklistTableAdapter1
		 // 
		 this.allstocklistTableAdapter1.ClearBeforeFill = true;
		 // 
		 // allstockdataTableAdapter1
		 // 
		 this.allstockdataTableAdapter1.ClearBeforeFill = true;
		 // 
		 // statusTextBox
		 // 
		 this.statusTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
		 this.statusTextBox.Location = new System.Drawing.Point(35, 86);
		 this.statusTextBox.Multiline = true;
		 this.statusTextBox.Name = "statusTextBox";
		 this.statusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		 this.statusTextBox.Size = new System.Drawing.Size(651, 116);
		 this.statusTextBox.TabIndex = 5;
		 // 
		 // button1
		 // 
		 this.button1.Location = new System.Drawing.Point(955, 25);
		 this.button1.Name = "button1";
		 this.button1.Size = new System.Drawing.Size(220, 34);
		 this.button1.TabIndex = 6;
		 this.button1.Text = "Update";
		 this.button1.UseVisualStyleBackColor = true;
		 this.button1.Click += new System.EventHandler(this.updateButton_Click);
		 // 
		 // readSymbolprogressBar
		 // 
		 this.readSymbolprogressBar.Location = new System.Drawing.Point(47, 233);
		 this.readSymbolprogressBar.Name = "readSymbolprogressBar";
		 this.readSymbolprogressBar.Size = new System.Drawing.Size(1083, 35);
		 this.readSymbolprogressBar.TabIndex = 7;
		 // 
		 // downloadprogressBar
		 // 
		 this.downloadprogressBar.Location = new System.Drawing.Point(47, 302);
		 this.downloadprogressBar.Name = "downloadprogressBar";
		 this.downloadprogressBar.Size = new System.Drawing.Size(1083, 35);
		 this.downloadprogressBar.TabIndex = 8;
		 // 
		 // generateSQLprogressBar
		 // 
		 this.generateSQLprogressBar.Location = new System.Drawing.Point(47, 369);
		 this.generateSQLprogressBar.Name = "generateSQLprogressBar";
		 this.generateSQLprogressBar.Size = new System.Drawing.Size(1083, 35);
		 this.generateSQLprogressBar.TabIndex = 9;
		 // 
		 // updateDBprogressBar
		 // 
		 this.updateDBprogressBar.Location = new System.Drawing.Point(47, 436);
		 this.updateDBprogressBar.Name = "updateDBprogressBar";
		 this.updateDBprogressBar.Size = new System.Drawing.Size(1083, 35);
		 this.updateDBprogressBar.TabIndex = 10;
		 // 
		 // readSymboltextBox
		 // 
		 this.readSymboltextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		 this.readSymboltextBox.Location = new System.Drawing.Point(1151, 235);
		 this.readSymboltextBox.Name = "readSymboltextBox";
		 this.readSymboltextBox.Size = new System.Drawing.Size(105, 35);
		 this.readSymboltextBox.TabIndex = 11;
		 // 
		 // DownloadtextBox
		 // 
		 this.DownloadtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		 this.DownloadtextBox.Location = new System.Drawing.Point(1151, 302);
		 this.DownloadtextBox.Name = "DownloadtextBox";
		 this.DownloadtextBox.Size = new System.Drawing.Size(105, 35);
		 this.DownloadtextBox.TabIndex = 12;
		 // 
		 // generateSQLtextBox
		 // 
		 this.generateSQLtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		 this.generateSQLtextBox.Location = new System.Drawing.Point(1151, 369);
		 this.generateSQLtextBox.Name = "generateSQLtextBox";
		 this.generateSQLtextBox.Size = new System.Drawing.Size(105, 35);
		 this.generateSQLtextBox.TabIndex = 13;
		 // 
		 // updateDBtextBox
		 // 
		 this.updateDBtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		 this.updateDBtextBox.Location = new System.Drawing.Point(1151, 436);
		 this.updateDBtextBox.Name = "updateDBtextBox";
		 this.updateDBtextBox.Size = new System.Drawing.Size(105, 35);
		 this.updateDBtextBox.TabIndex = 14;
		 // 
		 // deleteComboBox
		 // 
		 this.deleteComboBox.DataSource = this.dELSTOCKLISTBindingSource;
		 this.deleteComboBox.DisplayMember = "SYMBOL";
		 this.deleteComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		 this.deleteComboBox.FormattingEnabled = true;
		 this.deleteComboBox.Location = new System.Drawing.Point(726, 86);
		 this.deleteComboBox.Name = "deleteComboBox";
		 this.deleteComboBox.Size = new System.Drawing.Size(177, 35);
		 this.deleteComboBox.TabIndex = 15;
		 this.deleteComboBox.ValueMember = "SYMBOL";
		 this.deleteComboBox.SelectedIndexChanged += new System.EventHandler(this.deleteComboBox_SelectedIndexChanged);
		 // 
		 // dELSTOCKLISTBindingSource
		 // 
		 this.dELSTOCKLISTBindingSource.DataMember = "DELSTOCKLIST";
		 this.dELSTOCKLISTBindingSource.DataSource = this.removeStocksDataSet;
		 // 
		 // removeStocksDataSet
		 // 
		 this.removeStocksDataSet.DataSetName = "RemoveStocksDataSet";
		 this.removeStocksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
		 // 
		 // RemoveDatabutton
		 // 
		 this.RemoveDatabutton.Location = new System.Drawing.Point(976, 86);
		 this.RemoveDatabutton.Name = "RemoveDatabutton";
		 this.RemoveDatabutton.Size = new System.Drawing.Size(245, 71);
		 this.RemoveDatabutton.TabIndex = 16;
		 this.RemoveDatabutton.Text = "Move selected stock to old database";
		 this.RemoveDatabutton.UseVisualStyleBackColor = true;
		 this.RemoveDatabutton.Click += new System.EventHandler(this.RemoveDatabutton_Click);
		 // 
		 // dELSTOCKLISTTableAdapter
		 // 
		 this.dELSTOCKLISTTableAdapter.ClearBeforeFill = true;
		 // 
		 // label3
		 // 
		 this.label3.AutoSize = true;
		 this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		 this.label3.Location = new System.Drawing.Point(47, 209);
		 this.label3.Name = "label3";
		 this.label3.Size = new System.Drawing.Size(188, 26);
		 this.label3.TabIndex = 17;
		 this.label3.Text = "Reading Symbols";
		 // 
		 // label4
		 // 
		 this.label4.AutoSize = true;
		 this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		 this.label4.Location = new System.Drawing.Point(47, 277);
		 this.label4.Name = "label4";
		 this.label4.Size = new System.Drawing.Size(211, 26);
		 this.label4.TabIndex = 18;
		 this.label4.Text = "Download Progress";
		 // 
		 // label5
		 // 
		 this.label5.AutoSize = true;
		 this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		 this.label5.Location = new System.Drawing.Point(47, 344);
		 this.label5.Name = "label5";
		 this.label5.Size = new System.Drawing.Size(278, 26);
		 this.label5.TabIndex = 19;
		 this.label5.Text = "Generate SQL Statements";
		 // 
		 // label6
		 // 
		 this.label6.AutoSize = true;
		 this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		 this.label6.Location = new System.Drawing.Point(47, 411);
		 this.label6.Name = "label6";
		 this.label6.Size = new System.Drawing.Size(186, 26);
		 this.label6.TabIndex = 20;
		 this.label6.Text = "Update Database";
		 // 
		 // ReadSymbolPercentagelabel
		 // 
		 this.ReadSymbolPercentagelabel.AutoSize = true;
		 this.ReadSymbolPercentagelabel.BackColor = System.Drawing.Color.Transparent;
		 this.ReadSymbolPercentagelabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		 this.ReadSymbolPercentagelabel.Location = new System.Drawing.Point(563, 237);
		 this.ReadSymbolPercentagelabel.Name = "ReadSymbolPercentagelabel";
		 this.ReadSymbolPercentagelabel.Size = new System.Drawing.Size(55, 26);
		 this.ReadSymbolPercentagelabel.TabIndex = 21;
		 this.ReadSymbolPercentagelabel.Text = "0 %";
		 this.ReadSymbolPercentagelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		 // 
		 // downloadProgressPercentagelabel
		 // 
		 this.downloadProgressPercentagelabel.AutoSize = true;
		 this.downloadProgressPercentagelabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		 this.downloadProgressPercentagelabel.Location = new System.Drawing.Point(563, 306);
		 this.downloadProgressPercentagelabel.Name = "downloadProgressPercentagelabel";
		 this.downloadProgressPercentagelabel.Size = new System.Drawing.Size(55, 26);
		 this.downloadProgressPercentagelabel.TabIndex = 22;
		 this.downloadProgressPercentagelabel.Text = "0 %";
		 this.downloadProgressPercentagelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		 // 
		 // GenerateSQLPercentageLabel
		 // 
		 this.GenerateSQLPercentageLabel.AutoSize = true;
		 this.GenerateSQLPercentageLabel.BackColor = System.Drawing.Color.Transparent;
		 this.GenerateSQLPercentageLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		 this.GenerateSQLPercentageLabel.Location = new System.Drawing.Point(563, 373);
		 this.GenerateSQLPercentageLabel.Name = "GenerateSQLPercentageLabel";
		 this.GenerateSQLPercentageLabel.Size = new System.Drawing.Size(55, 26);
		 this.GenerateSQLPercentageLabel.TabIndex = 23;
		 this.GenerateSQLPercentageLabel.Text = "0 %";
		 this.GenerateSQLPercentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		 // 
		 // updateDBProgressPercentageLabel
		 // 
		 this.updateDBProgressPercentageLabel.AutoSize = true;
		 this.updateDBProgressPercentageLabel.BackColor = System.Drawing.Color.Transparent;
		 this.updateDBProgressPercentageLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		 this.updateDBProgressPercentageLabel.Location = new System.Drawing.Point(558, 440);
		 this.updateDBProgressPercentageLabel.Name = "updateDBProgressPercentageLabel";
		 this.updateDBProgressPercentageLabel.Size = new System.Drawing.Size(55, 26);
		 this.updateDBProgressPercentageLabel.TabIndex = 24;
		 this.updateDBProgressPercentageLabel.Text = "0 %";
		 this.updateDBProgressPercentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		 // 
		 // button2
		 // 
		 this.button2.Location = new System.Drawing.Point(281, 545);
		 this.button2.Name = "button2";
		 this.button2.Size = new System.Drawing.Size(209, 80);
		 this.button2.TabIndex = 25;
		 this.button2.Text = "Go to Insert Page";
		 this.button2.UseVisualStyleBackColor = true;
		 this.button2.Click += new System.EventHandler(this.button2_Click);
		 // 
		 // textBox1
		 // 
		 this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		 this.textBox1.Location = new System.Drawing.Point(726, 150);
		 this.textBox1.Name = "textBox1";
		 this.textBox1.Size = new System.Drawing.Size(191, 30);
		 this.textBox1.TabIndex = 26;
		 // 
		 // aLLSTOCKLISTBindingSource
		 // 
		 this.aLLSTOCKLISTBindingSource.DataMember = "ALLSTOCKLIST";
		 this.aLLSTOCKLISTBindingSource.DataSource = this.stocksDataSet;
		 // 
		 // aLLSTOCKLISTBindingSource1
		 // 
		 this.aLLSTOCKLISTBindingSource1.DataMember = "ALLSTOCKLIST";
		 this.aLLSTOCKLISTBindingSource1.DataSource = this.stocksDataSet;
		 // 
		 // UpdateForm
		 // 
		 this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
		 this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		 this.ClientSize = new System.Drawing.Size(1291, 668);
		 this.Controls.Add(this.textBox1);
		 this.Controls.Add(this.button2);
		 this.Controls.Add(this.updateDBProgressPercentageLabel);
		 this.Controls.Add(this.GenerateSQLPercentageLabel);
		 this.Controls.Add(this.downloadProgressPercentagelabel);
		 this.Controls.Add(this.ReadSymbolPercentagelabel);
		 this.Controls.Add(this.label6);
		 this.Controls.Add(this.label5);
		 this.Controls.Add(this.label4);
		 this.Controls.Add(this.label3);
		 this.Controls.Add(this.RemoveDatabutton);
		 this.Controls.Add(this.deleteComboBox);
		 this.Controls.Add(this.updateDBtextBox);
		 this.Controls.Add(this.generateSQLtextBox);
		 this.Controls.Add(this.DownloadtextBox);
		 this.Controls.Add(this.readSymboltextBox);
		 this.Controls.Add(this.updateDBprogressBar);
		 this.Controls.Add(this.generateSQLprogressBar);
		 this.Controls.Add(this.downloadprogressBar);
		 this.Controls.Add(this.readSymbolprogressBar);
		 this.Controls.Add(this.button1);
		 this.Controls.Add(this.statusTextBox);
		 this.Controls.Add(this.textBoxRecentDate);
		 this.Controls.Add(this.label2);
		 this.Controls.Add(this.textBoxTodaysDate);
		 this.Controls.Add(this.label1);
		 this.Name = "UpdateForm";
		 this.Text = "Update Stock Database";
		 this.Load += new System.EventHandler(this.Form1_Load);
		 ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
		 ((System.ComponentModel.ISupportInitialize)(this.stocksDataSet)).EndInit();
		 ((System.ComponentModel.ISupportInitialize)(this.dELSTOCKLISTBindingSource)).EndInit();
		 ((System.ComponentModel.ISupportInitialize)(this.removeStocksDataSet)).EndInit();
		 ((System.ComponentModel.ISupportInitialize)(this.aLLSTOCKLISTBindingSource)).EndInit();
		 ((System.ComponentModel.ISupportInitialize)(this.aLLSTOCKLISTBindingSource1)).EndInit();
		 this.ResumeLayout(false);
		 this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource bindingSource1;
		private StocksDataSet stocksDataSet;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxTodaysDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxRecentDate;
		private StocksDataSetTableAdapters.ALLSTOCKLISTTableAdapter allstocklistTableAdapter1;
		private StocksDataSetTableAdapters.ALLSTOCKDATATableAdapter allstockdataTableAdapter1;
		private System.Windows.Forms.TextBox statusTextBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ProgressBar readSymbolprogressBar;
		private System.Windows.Forms.ProgressBar downloadprogressBar;
		private System.Windows.Forms.ProgressBar generateSQLprogressBar;
		private System.Windows.Forms.ProgressBar updateDBprogressBar;
		private System.Windows.Forms.TextBox readSymboltextBox;
		private System.Windows.Forms.TextBox DownloadtextBox;
		private System.Windows.Forms.TextBox generateSQLtextBox;
		private System.Windows.Forms.TextBox updateDBtextBox;
		private System.Windows.Forms.ComboBox deleteComboBox;
		private System.Windows.Forms.Button RemoveDatabutton;
		private RemoveStocksDataSet removeStocksDataSet;
		private System.Windows.Forms.BindingSource dELSTOCKLISTBindingSource;
		private RemoveStocksDataSetTableAdapters.DELSTOCKLISTTableAdapter dELSTOCKLISTTableAdapter;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label ReadSymbolPercentagelabel;
		private System.Windows.Forms.Label downloadProgressPercentagelabel;
		private System.Windows.Forms.Label GenerateSQLPercentageLabel;
		private System.Windows.Forms.Label updateDBProgressPercentageLabel;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.BindingSource aLLSTOCKLISTBindingSource;
		private System.Windows.Forms.BindingSource aLLSTOCKLISTBindingSource1;
	}
}