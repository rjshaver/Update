namespace Update
{
   partial class InsertForm
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
		 System.Windows.Forms.Label sYMBOLLabel;
		 System.Windows.Forms.Label nAMELabel;
		 System.Windows.Forms.Label iPOYEARLabel;
		 System.Windows.Forms.Label sECTORLabel;
		 System.Windows.Forms.Label iNDUSTRYLabel;
		 System.Windows.Forms.Label eXCHANGELabel;
		 System.Windows.Forms.Label lINESOFDATALabel;
		 System.Windows.Forms.Label rECENTDATELabel;
		 System.Windows.Forms.Label dIVRECENTDATELabel;
		 System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertForm));
		 this.stocksDataSet = new Update.StocksDataSet();
		 this.aLLSTOCKLISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
		 this.aLLSTOCKLISTTableAdapter = new Update.StocksDataSetTableAdapters.ALLSTOCKLISTTableAdapter();
		 this.tableAdapterManager = new Update.StocksDataSetTableAdapters.TableAdapterManager();
		 this.aLLSTOCKLISTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
		 this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
		 this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
		 this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
		 this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
		 this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
		 this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
		 this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
		 this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		 this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
		 this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
		 this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
		 this.aLLSTOCKLISTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
		 this.sYMBOLTextBox = new System.Windows.Forms.TextBox();
		 this.nAMETextBox = new System.Windows.Forms.TextBox();
		 this.iPOYEARTextBox = new System.Windows.Forms.TextBox();
		 this.sECTORTextBox = new System.Windows.Forms.TextBox();
		 this.iNDUSTRYTextBox = new System.Windows.Forms.TextBox();
		 this.eXCHANGETextBox = new System.Windows.Forms.TextBox();
		 this.lINESOFDATATextBox = new System.Windows.Forms.TextBox();
		 this.rECENTDATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
		 this.dIVRECENTDATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
		 this.button1 = new System.Windows.Forms.Button();
		 sYMBOLLabel = new System.Windows.Forms.Label();
		 nAMELabel = new System.Windows.Forms.Label();
		 iPOYEARLabel = new System.Windows.Forms.Label();
		 sECTORLabel = new System.Windows.Forms.Label();
		 iNDUSTRYLabel = new System.Windows.Forms.Label();
		 eXCHANGELabel = new System.Windows.Forms.Label();
		 lINESOFDATALabel = new System.Windows.Forms.Label();
		 rECENTDATELabel = new System.Windows.Forms.Label();
		 dIVRECENTDATELabel = new System.Windows.Forms.Label();
		 ((System.ComponentModel.ISupportInitialize)(this.stocksDataSet)).BeginInit();
		 ((System.ComponentModel.ISupportInitialize)(this.aLLSTOCKLISTBindingSource)).BeginInit();
		 ((System.ComponentModel.ISupportInitialize)(this.aLLSTOCKLISTBindingNavigator)).BeginInit();
		 this.aLLSTOCKLISTBindingNavigator.SuspendLayout();
		 this.SuspendLayout();
		 // 
		 // sYMBOLLabel
		 // 
		 sYMBOLLabel.AutoSize = true;
		 sYMBOLLabel.Location = new System.Drawing.Point(182, 98);
		 sYMBOLLabel.Name = "sYMBOLLabel";
		 sYMBOLLabel.Size = new System.Drawing.Size(80, 20);
		 sYMBOLLabel.TabIndex = 1;
		 sYMBOLLabel.Text = "SYMBOL:";
		 // 
		 // nAMELabel
		 // 
		 nAMELabel.AutoSize = true;
		 nAMELabel.Location = new System.Drawing.Point(182, 130);
		 nAMELabel.Name = "nAMELabel";
		 nAMELabel.Size = new System.Drawing.Size(59, 20);
		 nAMELabel.TabIndex = 3;
		 nAMELabel.Text = "NAME:";
		 // 
		 // iPOYEARLabel
		 // 
		 iPOYEARLabel.AutoSize = true;
		 iPOYEARLabel.Location = new System.Drawing.Point(182, 162);
		 iPOYEARLabel.Name = "iPOYEARLabel";
		 iPOYEARLabel.Size = new System.Drawing.Size(85, 20);
		 iPOYEARLabel.TabIndex = 5;
		 iPOYEARLabel.Text = "IPOYEAR:";
		 // 
		 // sECTORLabel
		 // 
		 sECTORLabel.AutoSize = true;
		 sECTORLabel.Location = new System.Drawing.Point(182, 194);
		 sECTORLabel.Name = "sECTORLabel";
		 sECTORLabel.Size = new System.Drawing.Size(79, 20);
		 sECTORLabel.TabIndex = 7;
		 sECTORLabel.Text = "SECTOR:";
		 // 
		 // iNDUSTRYLabel
		 // 
		 iNDUSTRYLabel.AutoSize = true;
		 iNDUSTRYLabel.Location = new System.Drawing.Point(182, 226);
		 iNDUSTRYLabel.Name = "iNDUSTRYLabel";
		 iNDUSTRYLabel.Size = new System.Drawing.Size(96, 20);
		 iNDUSTRYLabel.TabIndex = 9;
		 iNDUSTRYLabel.Text = "INDUSTRY:";
		 // 
		 // eXCHANGELabel
		 // 
		 eXCHANGELabel.AutoSize = true;
		 eXCHANGELabel.Location = new System.Drawing.Point(182, 258);
		 eXCHANGELabel.Name = "eXCHANGELabel";
		 eXCHANGELabel.Size = new System.Drawing.Size(104, 20);
		 eXCHANGELabel.TabIndex = 11;
		 eXCHANGELabel.Text = "EXCHANGE:";
		 // 
		 // lINESOFDATALabel
		 // 
		 lINESOFDATALabel.AutoSize = true;
		 lINESOFDATALabel.Location = new System.Drawing.Point(182, 290);
		 lINESOFDATALabel.Name = "lINESOFDATALabel";
		 lINESOFDATALabel.Size = new System.Drawing.Size(125, 20);
		 lINESOFDATALabel.TabIndex = 13;
		 lINESOFDATALabel.Text = "LINESOFDATA:";
		 // 
		 // rECENTDATELabel
		 // 
		 rECENTDATELabel.AutoSize = true;
		 rECENTDATELabel.Location = new System.Drawing.Point(182, 323);
		 rECENTDATELabel.Name = "rECENTDATELabel";
		 rECENTDATELabel.Size = new System.Drawing.Size(121, 20);
		 rECENTDATELabel.TabIndex = 15;
		 rECENTDATELabel.Text = "RECENTDATE:";
		 // 
		 // dIVRECENTDATELabel
		 // 
		 dIVRECENTDATELabel.AutoSize = true;
		 dIVRECENTDATELabel.Location = new System.Drawing.Point(182, 355);
		 dIVRECENTDATELabel.Name = "dIVRECENTDATELabel";
		 dIVRECENTDATELabel.Size = new System.Drawing.Size(149, 20);
		 dIVRECENTDATELabel.TabIndex = 17;
		 dIVRECENTDATELabel.Text = "DIVRECENTDATE:";
		 // 
		 // stocksDataSet
		 // 
		 this.stocksDataSet.DataSetName = "StocksDataSet";
		 this.stocksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
		 // 
		 // aLLSTOCKLISTBindingSource
		 // 
		 this.aLLSTOCKLISTBindingSource.DataMember = "ALLSTOCKLIST";
		 this.aLLSTOCKLISTBindingSource.DataSource = this.stocksDataSet;
		 // 
		 // aLLSTOCKLISTTableAdapter
		 // 
		 this.aLLSTOCKLISTTableAdapter.ClearBeforeFill = true;
		 // 
		 // tableAdapterManager
		 // 
		 this.tableAdapterManager.ALLSTOCKDATATableAdapter = null;
		 this.tableAdapterManager.ALLSTOCKLISTTableAdapter = this.aLLSTOCKLISTTableAdapter;
		 this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
		 //this.tableAdapterManager.UpdateOrder = Update.StocksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
		 // 
		 // aLLSTOCKLISTBindingNavigator
		 // 
		 this.aLLSTOCKLISTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
		 this.aLLSTOCKLISTBindingNavigator.BindingSource = this.aLLSTOCKLISTBindingSource;
		 this.aLLSTOCKLISTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
		 this.aLLSTOCKLISTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
		 this.aLLSTOCKLISTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.bindingNavigatorMoveFirstItem,
			this.bindingNavigatorMovePreviousItem,
			this.bindingNavigatorSeparator,
			this.bindingNavigatorPositionItem,
			this.bindingNavigatorCountItem,
			this.bindingNavigatorSeparator1,
			this.bindingNavigatorMoveNextItem,
			this.bindingNavigatorMoveLastItem,
			this.bindingNavigatorSeparator2,
			this.bindingNavigatorAddNewItem,
			this.bindingNavigatorDeleteItem,
			this.aLLSTOCKLISTBindingNavigatorSaveItem});
		 this.aLLSTOCKLISTBindingNavigator.Location = new System.Drawing.Point(0, 0);
		 this.aLLSTOCKLISTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
		 this.aLLSTOCKLISTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
		 this.aLLSTOCKLISTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
		 this.aLLSTOCKLISTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
		 this.aLLSTOCKLISTBindingNavigator.Name = "aLLSTOCKLISTBindingNavigator";
		 this.aLLSTOCKLISTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
		 this.aLLSTOCKLISTBindingNavigator.Size = new System.Drawing.Size(866, 31);
		 this.aLLSTOCKLISTBindingNavigator.TabIndex = 0;
		 this.aLLSTOCKLISTBindingNavigator.Text = "bindingNavigator1";
		 // 
		 // bindingNavigatorAddNewItem
		 // 
		 this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		 this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
		 this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
		 this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
		 this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 28);
		 this.bindingNavigatorAddNewItem.Text = "Add new";
		 this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
		 // 
		 // bindingNavigatorCountItem
		 // 
		 this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
		 this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
		 this.bindingNavigatorCountItem.Text = "of {0}";
		 this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
		 // 
		 // bindingNavigatorDeleteItem
		 // 
		 this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		 this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
		 this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
		 this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
		 this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 28);
		 this.bindingNavigatorDeleteItem.Text = "Delete";
		 // 
		 // bindingNavigatorMoveFirstItem
		 // 
		 this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		 this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
		 this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
		 this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
		 this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 28);
		 this.bindingNavigatorMoveFirstItem.Text = "Move first";
		 // 
		 // bindingNavigatorMovePreviousItem
		 // 
		 this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		 this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
		 this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
		 this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
		 this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 28);
		 this.bindingNavigatorMovePreviousItem.Text = "Move previous";
		 // 
		 // bindingNavigatorSeparator
		 // 
		 this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
		 this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
		 // 
		 // bindingNavigatorPositionItem
		 // 
		 this.bindingNavigatorPositionItem.AccessibleName = "Position";
		 this.bindingNavigatorPositionItem.AutoSize = false;
		 this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
		 this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
		 this.bindingNavigatorPositionItem.Text = "0";
		 this.bindingNavigatorPositionItem.ToolTipText = "Current position";
		 // 
		 // bindingNavigatorSeparator1
		 // 
		 this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
		 this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
		 // 
		 // bindingNavigatorMoveNextItem
		 // 
		 this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		 this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
		 this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
		 this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
		 this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 28);
		 this.bindingNavigatorMoveNextItem.Text = "Move next";
		 // 
		 // bindingNavigatorMoveLastItem
		 // 
		 this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		 this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
		 this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
		 this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
		 this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 28);
		 this.bindingNavigatorMoveLastItem.Text = "Move last";
		 // 
		 // bindingNavigatorSeparator2
		 // 
		 this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
		 this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
		 // 
		 // aLLSTOCKLISTBindingNavigatorSaveItem
		 // 
		 this.aLLSTOCKLISTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		 this.aLLSTOCKLISTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aLLSTOCKLISTBindingNavigatorSaveItem.Image")));
		 this.aLLSTOCKLISTBindingNavigatorSaveItem.Name = "aLLSTOCKLISTBindingNavigatorSaveItem";
		 this.aLLSTOCKLISTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 28);
		 this.aLLSTOCKLISTBindingNavigatorSaveItem.Text = "Save Data";
		 this.aLLSTOCKLISTBindingNavigatorSaveItem.Click += new System.EventHandler(this.aLLSTOCKLISTBindingNavigatorSaveItem_Click);
		 // 
		 // sYMBOLTextBox
		 // 
		 this.sYMBOLTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLLSTOCKLISTBindingSource, "SYMBOL", true));
		 this.sYMBOLTextBox.Location = new System.Drawing.Point(337, 95);
		 this.sYMBOLTextBox.Name = "sYMBOLTextBox";
		 this.sYMBOLTextBox.Size = new System.Drawing.Size(200, 26);
		 this.sYMBOLTextBox.TabIndex = 2;
		 // 
		 // nAMETextBox
		 // 
		 this.nAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLLSTOCKLISTBindingSource, "NAME", true));
		 this.nAMETextBox.Location = new System.Drawing.Point(337, 127);
		 this.nAMETextBox.Name = "nAMETextBox";
		 this.nAMETextBox.Size = new System.Drawing.Size(200, 26);
		 this.nAMETextBox.TabIndex = 4;
		 // 
		 // iPOYEARTextBox
		 // 
		 this.iPOYEARTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLLSTOCKLISTBindingSource, "IPOYEAR", true));
		 this.iPOYEARTextBox.Location = new System.Drawing.Point(337, 159);
		 this.iPOYEARTextBox.Name = "iPOYEARTextBox";
		 this.iPOYEARTextBox.Size = new System.Drawing.Size(200, 26);
		 this.iPOYEARTextBox.TabIndex = 6;
		 // 
		 // sECTORTextBox
		 // 
		 this.sECTORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLLSTOCKLISTBindingSource, "SECTOR", true));
		 this.sECTORTextBox.Location = new System.Drawing.Point(337, 191);
		 this.sECTORTextBox.Name = "sECTORTextBox";
		 this.sECTORTextBox.Size = new System.Drawing.Size(200, 26);
		 this.sECTORTextBox.TabIndex = 8;
		 // 
		 // iNDUSTRYTextBox
		 // 
		 this.iNDUSTRYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLLSTOCKLISTBindingSource, "INDUSTRY", true));
		 this.iNDUSTRYTextBox.Location = new System.Drawing.Point(337, 223);
		 this.iNDUSTRYTextBox.Name = "iNDUSTRYTextBox";
		 this.iNDUSTRYTextBox.Size = new System.Drawing.Size(200, 26);
		 this.iNDUSTRYTextBox.TabIndex = 10;
		 // 
		 // eXCHANGETextBox
		 // 
		 this.eXCHANGETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLLSTOCKLISTBindingSource, "EXCHANGE", true));
		 this.eXCHANGETextBox.Location = new System.Drawing.Point(337, 255);
		 this.eXCHANGETextBox.Name = "eXCHANGETextBox";
		 this.eXCHANGETextBox.Size = new System.Drawing.Size(200, 26);
		 this.eXCHANGETextBox.TabIndex = 12;
		 // 
		 // lINESOFDATATextBox
		 // 
		 this.lINESOFDATATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLLSTOCKLISTBindingSource, "LINESOFDATA", true));
		 this.lINESOFDATATextBox.Location = new System.Drawing.Point(337, 287);
		 this.lINESOFDATATextBox.Name = "lINESOFDATATextBox";
		 this.lINESOFDATATextBox.Size = new System.Drawing.Size(200, 26);
		 this.lINESOFDATATextBox.TabIndex = 14;
		 // 
		 // rECENTDATEDateTimePicker
		 // 
		 this.rECENTDATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aLLSTOCKLISTBindingSource, "RECENTDATE", true));
		 this.rECENTDATEDateTimePicker.Location = new System.Drawing.Point(337, 319);
		 this.rECENTDATEDateTimePicker.Name = "rECENTDATEDateTimePicker";
		 this.rECENTDATEDateTimePicker.Size = new System.Drawing.Size(200, 26);
		 this.rECENTDATEDateTimePicker.TabIndex = 16;
		 // 
		 // dIVRECENTDATEDateTimePicker
		 // 
		 this.dIVRECENTDATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aLLSTOCKLISTBindingSource, "DIVRECENTDATE", true));
		 this.dIVRECENTDATEDateTimePicker.Location = new System.Drawing.Point(337, 351);
		 this.dIVRECENTDATEDateTimePicker.Name = "dIVRECENTDATEDateTimePicker";
		 this.dIVRECENTDATEDateTimePicker.Size = new System.Drawing.Size(200, 26);
		 this.dIVRECENTDATEDateTimePicker.TabIndex = 18;
		 // 
		 // button1
		 // 
		 this.button1.Location = new System.Drawing.Point(320, 420);
		 this.button1.Name = "button1";
		 this.button1.Size = new System.Drawing.Size(184, 61);
		 this.button1.TabIndex = 19;
		 this.button1.Text = "Done inserting";
		 this.button1.UseVisualStyleBackColor = true;
		 this.button1.Click += new System.EventHandler(this.button1_Click);
		 // 
		 // InsertForm
		 // 
		 this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
		 this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		 this.ClientSize = new System.Drawing.Size(866, 572);
		 this.ControlBox = false;
		 this.Controls.Add(this.button1);
		 this.Controls.Add(sYMBOLLabel);
		 this.Controls.Add(this.sYMBOLTextBox);
		 this.Controls.Add(nAMELabel);
		 this.Controls.Add(this.nAMETextBox);
		 this.Controls.Add(iPOYEARLabel);
		 this.Controls.Add(this.iPOYEARTextBox);
		 this.Controls.Add(sECTORLabel);
		 this.Controls.Add(this.sECTORTextBox);
		 this.Controls.Add(iNDUSTRYLabel);
		 this.Controls.Add(this.iNDUSTRYTextBox);
		 this.Controls.Add(eXCHANGELabel);
		 this.Controls.Add(this.eXCHANGETextBox);
		 this.Controls.Add(lINESOFDATALabel);
		 this.Controls.Add(this.lINESOFDATATextBox);
		 this.Controls.Add(rECENTDATELabel);
		 this.Controls.Add(this.rECENTDATEDateTimePicker);
		 this.Controls.Add(dIVRECENTDATELabel);
		 this.Controls.Add(this.dIVRECENTDATEDateTimePicker);
		 this.Controls.Add(this.aLLSTOCKLISTBindingNavigator);
		 this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		 this.Name = "InsertForm";
		 this.Text = "InsertForm";
		 this.Load += new System.EventHandler(this.InsertForm_Load);
		 ((System.ComponentModel.ISupportInitialize)(this.stocksDataSet)).EndInit();
		 ((System.ComponentModel.ISupportInitialize)(this.aLLSTOCKLISTBindingSource)).EndInit();
		 ((System.ComponentModel.ISupportInitialize)(this.aLLSTOCKLISTBindingNavigator)).EndInit();
		 this.aLLSTOCKLISTBindingNavigator.ResumeLayout(false);
		 this.aLLSTOCKLISTBindingNavigator.PerformLayout();
		 this.ResumeLayout(false);
		 this.PerformLayout();

	  }

	  #endregion

	  private StocksDataSet stocksDataSet;
	  private System.Windows.Forms.BindingSource aLLSTOCKLISTBindingSource;
	  private StocksDataSetTableAdapters.ALLSTOCKLISTTableAdapter aLLSTOCKLISTTableAdapter;
	  private StocksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
	  private System.Windows.Forms.BindingNavigator aLLSTOCKLISTBindingNavigator;
	  private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
	  private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
	  private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
	  private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
	  private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
	  private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
	  private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
	  private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
	  private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
	  private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
	  private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
	  private System.Windows.Forms.ToolStripButton aLLSTOCKLISTBindingNavigatorSaveItem;
	  private System.Windows.Forms.TextBox sYMBOLTextBox;
	  private System.Windows.Forms.TextBox nAMETextBox;
	  private System.Windows.Forms.TextBox iPOYEARTextBox;
	  private System.Windows.Forms.TextBox sECTORTextBox;
	  private System.Windows.Forms.TextBox iNDUSTRYTextBox;
	  private System.Windows.Forms.TextBox eXCHANGETextBox;
	  private System.Windows.Forms.TextBox lINESOFDATATextBox;
	  private System.Windows.Forms.DateTimePicker rECENTDATEDateTimePicker;
	  private System.Windows.Forms.DateTimePicker dIVRECENTDATEDateTimePicker;
	  private System.Windows.Forms.Button button1;
   }
}