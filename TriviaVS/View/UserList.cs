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

namespace TriviaVS
{
	public partial class UserList : Form
	{
		public User user { set; get; }

		public UserList()
		{
			InitializeComponent();
		}

		private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			//Auto Increment
			if (idTextBox.Text == null)
			{
				idTextBox.Text = (this.triviaDataSet11.Users.Count + 1).ToString();
				this.Validate();
				this.usersBindingSource.EndEdit();
				this.tableAdapterManager.UpdateAll(this.triviaDataSet11);
			}
			else
			{
				this.Validate();
				this.usersBindingSource.EndEdit();
				this.tableAdapterManager.UpdateAll(this.triviaDataSet11);
			}
		}

		private void UserList_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'triviaDataSet11.Users' table. You can move, or remove it, as needed.
			this.usersTableAdapter.Fill(this.triviaDataSet11.Users);

		}
	}
}
