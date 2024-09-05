using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
	internal class CustomExp: ApplicationException
	{
		public  CustomExp() {
			exp();
		}
		public string exp()
		{
			return ("THis is an Custom Exception");
		}
	}
}
