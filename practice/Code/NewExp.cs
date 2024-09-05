using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
	internal class NewExp
	{
		public void exp()
		{
			try
			{
				throw new CustomExp();
			}
			catch (Exception e) {
				Console.WriteLine(e.ToString());
			}
		}
	}
}
