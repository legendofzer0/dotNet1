using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
	public class DeligateTest
	{
		public delegate void addnum(int a, int b);
		public delegate void subnum(int a, int b);
		public void sum(int a, int b)
		{
			Console.WriteLine( a + b);
		}

		public void subtract(int a, int b)
		{
			Console.WriteLine( a - b);
		}

	}
}
