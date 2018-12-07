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
	public partial class MySubscribe : Form
	{
		User user;
		DataConnection db = new DataConnection();

		public MySubscribe(User user)
		{
			this.user = user;
			InitializeComponent();
		}

		private void friendsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.friendsBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.triviaDataSet);
		}

		private void MySubscribe_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'triviaDataSet2.Users' table. You can move, or remove it, as needed.
			this.usersTableAdapter.Fill(this.triviaDataSet2.Users);
			// TODO: This line of code loads data into the 'triviaDataSet.Friends' table. You can move, or remove it, as needed.
			this.friendsTableAdapter.Fill(this.triviaDataSet.Friends);
		}

		private void friendsBindingNavigator_RefreshItems(object sender, EventArgs e)
		{

		}
	}
}
