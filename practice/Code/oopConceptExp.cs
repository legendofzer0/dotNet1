using System;
namespace ConsoleAPP
{public class Animal
{
    public string Name { get; }

    public Animal(string name)
    {
        this.Name = name;
    }

    public virtual void Speak()
    {
        Console.WriteLine("Animal makes sound");
    }
}

    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        public override void Speak()
        {
            Console.WriteLine(Name + " says Woof");
        }
    }
}

/*public class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override void Speak()
    {
        Console.WriteLine(Name + " says Meow");
    }
}
*/

