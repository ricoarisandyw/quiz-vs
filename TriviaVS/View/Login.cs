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
	public partial class Login : Form
	{
		DataConnection db = new DataConnection();
		public Login()
		{
			InitializeComponent();
			CenterToScreen();
		}

		private void BtnLogin_Click(object sender, EventArgs e)
		{
			//MENDAPATKAN SEMUA
			User user = db.Users
				.Where(c => c.username == BoxUsername.Text)
				.Where(c => c.password == BoxPassword.Text).FirstOrDefault();
			if (user != null)
			{
				MessageBox.Show("Login Sukses");
				this.Hide();
				Home home = new Home();
				home.SetUser(user);
				home.Show();
			}
			else
			{
				MessageBox.Show("Login Gagal");
			}
		}

		private void BtnRegister_Click(object sender, EventArgs e)
		{
			User user = db.Users
				.Where(c => c.username == BoxUsername.Text).FirstOrDefault();
			if (user != null)
			{
				MessageBox.Show("Username sudah dipakai");
			}
			else
			{
				User userbaru = new User();
				userbaru.username = BoxUsername.Text;
				userbaru.password = BoxPassword.Text;
				db.Users.Add(userbaru);
				db.SaveChanges();
				MessageBox.Show("Register Berhasil");
			}
		}

		private static string GetUsername(User c)
		{
			return c.username;
		}
	}
}
