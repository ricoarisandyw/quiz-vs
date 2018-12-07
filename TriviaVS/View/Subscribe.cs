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
	public partial class Subscribe : Form
	{
		public User user;
		DataConnection db = new DataConnection();
		DataTable dtTable;
		string username = "Username";

		public Subscribe(User user)
		{
			this.user = user;
			InitializeComponent();
		}

		private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.usersBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.triviaDataSet2);
		}

		private void Friend_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'triviaDataSet2.Users' table. You can move, or remove it, as needed.
			this.usersTableAdapter.Fill(this.triviaDataSet2.Users);
		}

		//FIND
		private void button1_Click(object sender, EventArgs e)
		{
			this.usersBindingSource.Filter = string.Format("[{0}] LIKE '%{1}%' ", username, BoxFind.Text);
			this.tableAdapterManager.UpdateAll(this.triviaDataSet2);
		}

		//FOLLOW
		private void button2_Click(object sender, EventArgs e)
		{
			Friend friend = new Friend();
			User target = db.Users.Where(p => p.username == BoxFind.Text).FirstOrDefault();
			if (target == null)
			{
				MessageBox.Show("Periksa kembali Username yang dimasukan");
			}
			else
			{
				friend.id_followed = target.id;
				friend.id_follower = user.id;
				db.Friends.Add(friend);
				db.SaveChanges();
				MessageBox.Show("Berhasil berteman");
			}
		}
	}
}
