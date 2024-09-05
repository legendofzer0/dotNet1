using System;

namespace Code
{
    public class paramsClass
    {
        public  void Value(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public  void Reference(ref int a, ref int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
