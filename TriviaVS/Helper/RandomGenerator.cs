using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaVS.Model;

namespace TriviaVS.Helper
{
	class RandomGenerator
	{
		public List<int> create(int range)
		{
			List<int> listNumbers = new List<int>();
			int number = 0;
			for (int i = 0; i < range; i++)
			{
				do
				{
					if (listNumbers.Count == range) break;
					number = new Random().Next(1,range+1);
				} while (listNumbers.Contains(number));
				listNumbers.Add(number);
			}
			return listNumbers;
		}
	}
}
