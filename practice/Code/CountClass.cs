using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    internal class CountClass
    {
        public static int count = 0;
         public CountClass()
        {
            count++;
        }
        public static void Counted()
        {
            Console.WriteLine(count);
        }
    }
}
