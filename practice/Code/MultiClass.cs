using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    internal class MultiClass : test1, test2
    {
        public void add()
        {
            Console.WriteLine("ADD");
        }

        public void div()
        {
            Console.WriteLine("Div");
        }

        public void mul()
        {
            Console.WriteLine("MUL");
        }

        public void sub()
        {
            Console.WriteLine("SUB");
        }
    }
}
