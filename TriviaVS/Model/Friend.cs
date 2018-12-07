using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaVS.Model
{
	public class Friend
	{
		public int id { set; get; }
		public int id_follower { set; get; }
		public int id_followed { set; get; }
	}
}
