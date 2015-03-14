using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Update

{
   public partial class InsertForm : Form
   {
	  UpdateForm prevform;

	  public InsertForm()
	  {
		 InitializeComponent();
	  }

	  public InsertForm(UpdateForm of)
	  {
		 prevform = of;
		 InitializeComponent();
	  }

	  private void aLLSTOCKLISTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
	  {
		 this.Validate();
		 this.aLLSTOCKLISTBindingSource.EndEdit();
		 this.tableAdapterManager.UpdateAll(this.stocksDataSet);

	  }

	  private void InsertForm_Load(object sender, EventArgs e)
	  {
		 // TODO: This line of code loads data into the 'stocksDataSet.ALLSTOCKLIST' table. You can move, or remove it, as needed.
		 this.aLLSTOCKLISTTableAdapter.Fill(this.stocksDataSet.ALLSTOCKLIST);

	  }

	  private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
	  {
		 this.Validate();
		 this.aLLSTOCKLISTTableAdapter.Update(stocksDataSet.ALLSTOCKLIST);

	  }

	  private void button1_Click(object sender, EventArgs e)
	  {
		 //this.Parent.Show();
		 prevform.Show();
		 this.Hide();
		 this.Dispose();
	  }
   }
}
