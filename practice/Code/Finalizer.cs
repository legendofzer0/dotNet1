using System;

namespace Code
{
    internal class Finalizer
    {
        ~Finalizer()
        {
            Console.WriteLine("This is the finalizer being executed");
        }
    }

    internal class Finalizer2
    {
        public void finaler()
        {
            try
            {
                Console.WriteLine("This is a try block");
            }
            catch
            {
                Console.WriteLine("This is a catch block");
            }
            finally
            {
                Console.WriteLine("This is a finally block");
            }
        }
    }

    
}
