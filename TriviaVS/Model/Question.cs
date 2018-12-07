using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaVS.Model
{
	public class Question
	{
		public int id { set; get; }
		public int created_by { set; get; }
		public string question { set; get; }
		public string answer { set; get; }
	}
}
