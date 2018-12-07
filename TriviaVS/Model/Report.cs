using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaVS.Model
{
	public class Report
	{
		public int id { set; get; }
		public int id_user { set; get; }
		public int id_question { set; get; }
		public string message { set; get; }
	}
}
