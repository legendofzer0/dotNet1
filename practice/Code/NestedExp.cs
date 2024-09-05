using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
	internal class NestedExp
	{
		public void Nest()
		{
			try
			{
				int i = 0;
				int b = 10;
				try
				{
					int[] a = new int[] { 1, 2, 3 };
					Console.WriteLine(a[6]);
					int z = b / i;

				}
				catch (IndexOutOfRangeException e)
				{
					Console.WriteLine(e.ToString());
				}
				finally {
					Console.WriteLine("This is Inner Finally");
				}
			}
			catch (Exception e){ 
					Console.WriteLine(e.ToString());
				}
			finally
			{
				Console.WriteLine("This is Outer Finally");
			}
		}
	}
}
