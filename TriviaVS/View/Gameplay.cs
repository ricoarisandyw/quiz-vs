using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TriviaVS.Helper;
using TriviaVS.Model;
namespace TriviaVS
{
	public partial class Gameplay : Form
	{
		DataConnection db;
		List<Question> questions;
		GameplayHelper gameplayHelper;
		List<int> randomNumber;
		int questionIndex = 0;
		int point = 0;
		User user;

		public void setUser(User user)
		{
			this.user = user;
		}

		public Gameplay()
		{
			InitializeComponent();
			CenterToScreen();
			//Generate Random Number
			db = new DataConnection();
			//GET ALL QUESTION
			questions = db.Questions.ToList();
			gameplayHelper = new GameplayHelper();
			//GENERATE RANDOM NUMBER FOR QUESTION
			randomNumber = new RandomGenerator().create(db.Questions.Count());
			Question que = questions[randomNumber[questionIndex]];
			gameplayHelper.setQuestion(que);
			LblQuestion.Text = gameplayHelper.question.question;
			LblAnswer.Text = gameplayHelper.Guest(' ');
		}

		private void BtnAnswer_Click(object sender, EventArgs e)
		{
			if (BoxAnswer.Text.Length > 1)
			{
				MessageBox.Show("You only can put 1 word");
			}
			else
			{
				//Set Label based on GameHelper
				LblAnswer.Text = gameplayHelper.Guest(BoxAnswer.Text[0]);
				BoxAnswer.Text = "";
				if (!LblAnswer.Text.Contains("_"))
				{
					questionIndex++;
					if (questionIndex >= db.Questions.Count() || questionIndex >= 10)
					{
						MessageBox.Show("Terima kasih telah bermain");
						this.Close();
					}
					point += 10;
					LblPoint.Text = "Point : " + point.ToString();
					gameplayHelper.setQuestion(db.Questions.Find(randomNumber[questionIndex]));
					LblQuestion.Text = gameplayHelper.question.question;
					LblAnswer.Text = gameplayHelper.Guest(' ');
				}
			}
		}

		//=====Guest
		private void BtnSkip_Click(object sender, EventArgs e)
		{
			if (BoxAnswer.Text == gameplayHelper.question.answer)
			{
				questionIndex++;
				if (questionIndex >= db.Questions.Count() || questionIndex >= 10)
				{
					Score score = new Score
					{
						id_user = user.id,
						score = this.point
					};
					db.Scores.Add(score);
					db.SaveChanges();
					MessageBox.Show("Terima kasih telah bermain");
					this.Close();
				}
				point += 10;
				MessageBox.Show("Waw sudah terjawab!!!");
				BoxAnswer.Text = "";
				LblPoint.Text = "Point : " + point.ToString();
				gameplayHelper.setQuestion(questions[randomNumber[questionIndex-1]]);
				LblQuestion.Text = gameplayHelper.question.question;
				LblAnswer.Text = gameplayHelper.Guest(' ');
			}
			else
			{
				point -= 5;
				BoxAnswer.Text = "";
				LblPoint.Text = "Point : " + point.ToString();
				MessageBox.Show("Duh bukan itu!!!");
			}
		}

		void nextQuestion()
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//REPORT
		private void btnReport_Click(object sender, EventArgs e)
		{
			Report report = new Report();
			report.message = boxReport.Text;
			report.id_user = user.id;
			report.id_question = questions[questionIndex].id;
			db.Reports.Add(report);
			db.SaveChanges();
		}
	}
}
