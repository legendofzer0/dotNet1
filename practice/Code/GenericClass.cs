using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
	public class GenericClass<TManufacturer, TModel, TYear>
	{

		public TManufacturer manufacturer;
		public TModel model;
		public TYear year;

		public GenericClass(TManufacturer manufacturer, TModel model, TYear year)
		{
			this.manufacturer = manufacturer;
			this.model = model;
			this.year = year;

		}

		public void getData()
		{
			Console.WriteLine(string.Concat(manufacturer , model , year));
		}
	}
}
