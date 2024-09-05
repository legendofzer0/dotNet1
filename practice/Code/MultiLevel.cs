using System;

namespace Code
{
    public class MultiLevel
    {
        public int a = 10;
    }
    public class B : MultiLevel
    {
        public int b = 10;
    }
    public class C : B
    {
        void test()
        {
            int add = a + b;
            Console.WriteLine(add);
        }
    }
}
