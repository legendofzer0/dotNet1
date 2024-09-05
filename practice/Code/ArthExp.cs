using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
	internal class ArthExp
	{
		public void exe()
		{
			try
			{
				int a = 0;
				int b = 10;
				int c = b / a;
				Console.WriteLine(c);
			}
			catch (ArithmeticException e)
			{
				Console.WriteLine(e.ToString());
			}
		}
	}
}