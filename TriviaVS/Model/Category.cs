using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaVS.Model
{
	public class Category
	{
		public int id { set; get; }
		public int id_question { set; get; }
		public string category { set; get; }
	}
}
