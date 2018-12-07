using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriviaVS.Helper;
using TriviaVS.Model;
using TriviaVS.View;

namespace TriviaVS
{
	public partial class Home : Form
	{
		public User user { set; get; }

		public Home()
		{
			InitializeComponent();
		}

		public void SetUser(User user)
		{
			this.user = user;
			LblUsername.Text = user.username;
		}

		private void BtnGuest_Click(object sender, EventArgs e)
		{
			SoalList soalList = new SoalList();
			soalList.SetUser(this.user);
			soalList.Show();
		}

		private void BtnBermain_Click(object sender, EventArgs e)
		{
			Gameplay game = new Gameplay();
			game.setUser(user);
			game.Show();
		}

		private void scoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.scoresBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.triviaDataSet2);
		}

		private void Home_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'triviaDataSet2.Scores' table. You can move, or remove it, as needed.
			this.scoresTableAdapter.Fill(this.triviaDataSet2.Scores);

		}

		//SUBSCRIBE BUTTON
		private void button2_Click(object sender, EventArgs e)
		{
			new Subscribe(user).Show();
		}

		//MY SUBSCRIBE
		private void button1_Click(object sender, EventArgs e)
		{
			new MySubscribe(user).Show();
		}

		//KATEGORIKAN SOAL
		private void button3_Click(object sender, EventArgs e)
		{
			new Categorizing().Show();
		}

		//DAFTAR KATEGORI
		private void button4_Click(object sender, EventArgs e)
		{
			new View.Category().Show();
		}
	}
}
