using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
	internal class MultiException
	{
		void exo(){
			try
			{
				int a = 0, b = 0, c = 0;
				c = a / b;

			}
			catch (ArithmeticException e)
			{
				Console.WriteLine(e.ToString());
			}
			catch (IndexOutOfRangeException e)
			{
				Console.WriteLine(e.ToString());
			}
			catch (Exception e){
				Console.WriteLine(e.ToString());
			}
			
	}
	}
}
