using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriviaVS.Model;

namespace TriviaVS.View
{
	public partial class Categorizing : Form
	{
		DataConnection db = new DataConnection();

		public Categorizing()
		{
			InitializeComponent();
			
			List<Model.Category> categories = db.Categories.ToList();
			IEnumerable<string> cc = categories.Select(x => x.category).Distinct();
			cmbCategory.DataSource = cc.ToArray();
		}

		private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.categoriesBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.triviaDataSet);
		}

		private void Categorizing_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'triviaDataSet.Categories' table. You can move, or remove it, as needed.
			this.categoriesTableAdapter.Fill(this.triviaDataSet.Categories);
			this.categoriesBindingSource.Filter = string.Format("[{0}] <> '0' ","id_question");
			this.tableAdapterManager.UpdateAll(this.triviaDataSet);
		}

		//FIND
		private void BtnGuest_Click(object sender, EventArgs e)
		{
			(categoriesDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("question like %{0}% or answer like %{0}%",BoxFind.Text);
		}

		//SIMPAN
		private void button1_Click(object sender, EventArgs e)
		{
			categoryTextBox.Text = cmbCategory.Text;
			this.Validate();
			this.categoriesBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.triviaDataSet);
		}
	}
}
