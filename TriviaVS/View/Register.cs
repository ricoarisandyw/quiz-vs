using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaVS
{
	public partial class Register : Form
	{
		public Register()
		{
			InitializeComponent();
			CenterToScreen();
		}

		private void Login_Click(object sender, EventArgs e)
		{
			new Login().Show();
		}

		private void Register_Click(object sender, EventArgs e)
		{
			if (BoxUsername.Text == "rico")
			{
				MessageBox.Show("Welcome to Quiz");
			}
			else
			{
				MessageBox.Show("Incorrect Username or Password");
			}
		}
	}
}
