using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace TriviaVS.Model
{
	public class Score
	{
		public int id { set; get; }
		public int id_user { set; get; }
		public int id_category { set; get; }
		public int score { set; get; }
	}
}
