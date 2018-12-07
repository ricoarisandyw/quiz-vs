using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriviaVS.Model;

namespace TriviaVS.Helper
{
	class GameplayHelper
	{
		public Question question { set; get; }
		public char[] blankQuestion { set; get; }
		public User user { set; get; }
		void setUser(User user)
		{
			this.user = user;
		}


		public string Guest(char answer)
		{
			if (answer != null)
			{
				//1. Untuk setiap kata di {question.answer} samakan dengan {answer}
				bool found = false;
				for (int i = 0; i < question.answer.Length; i++)
				{	
					//2. Jika sama maka ubah karakter {blankQuestion} dengan huruf yang benar
					if (answer == question.answer[i])
					{
						found = true;
						blankQuestion[i] = answer;
					}
				}
				if (found)
				{
					MessageBox.Show("Yeeaaiii Dapat");
				}
				else if(answer==' ')
				{
					MessageBox.Show("Mari kita mulai");
				}else
				{
					MessageBox.Show("Sayang Sekali");
				}
			}
			//Check if question is true
			//Return new string of question
			return Regex.Replace(new string(blankQuestion), ".{1}", "$0 "); ;
		}

		public void setQuestion(Question q)
		{
			this.question = q;
			blankQuestion = question.answer.ToCharArray();
			foreach(int i in Enumerable.Range(0,question.answer.Length))
			{
				blankQuestion[i] = '_';
			}
		}
	}
}
