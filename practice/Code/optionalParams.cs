using System;
using System.Globalization;

namespace Code
{
    public class optionalParams
    {
       public void Jenish(string firstName, int age, string? lastName=null){
            Console.WriteLine("Hello i am "+firstName+" "+lastName+". i am "+age+"years old");
        }
    }
}
