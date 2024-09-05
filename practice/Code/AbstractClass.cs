using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public abstract class AbstractClass
    {
        public abstract void run();
    }
    public class newAbbs:AbstractClass {
        public override void run()
        {
            Console.WriteLine("I am Overrided abstract");
        }
    }
}
