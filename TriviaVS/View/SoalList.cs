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
	public partial class SoalList : Form
	{
		public User user { set; get; }

		public SoalList()
		{
			InitializeComponent();
			created_byTextBox.ReadOnly = true;
			idTextBox.ReadOnly = true;
		}

		public void SetUser(User user)
		{
			this.user = user;
			created_byTextBox.Text = user.id.ToString();
		}

		private void questionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			created_byTextBox.Text = user.id.ToString();
			this.Validate();
			this.questionsBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.triviaDataSet2);
		}

		private void SoalList_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'triviaDataSet2.Questions' table. You can move, or remove it, as needed.
			this.questionsTableAdapter.Fill(this.triviaDataSet2.Questions);

		}
	}
}
