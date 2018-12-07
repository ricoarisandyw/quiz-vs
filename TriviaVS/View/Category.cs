using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaVS.View
{
	public partial class Category : Form
	{
		public Category()
		{
			InitializeComponent();
		}

		private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.id_questionTextBox.Text = "0";
			this.Validate();
			this.categoriesBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.triviaDataSet);

		}

		private void Category_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'triviaDataSet.Categories' table. You can move, or remove it, as needed.
			this.categoriesTableAdapter.Fill(this.triviaDataSet.Categories);

		}
	}
}
