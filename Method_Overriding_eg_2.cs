using System;
namespace Polymorphism
{//This is an example of Run-time Polymorphism; also known as Method Overriding.
 //Method Overriding is achieved by the use of Inheritance.
    class Animal
    {
        public void eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }
    class Lion:Animal
    {
        public void eat()
        {
            Console.WriteLine("Lion is eating.");
        }
    }
    class Tiger : Lion
    {
        public void eat()
        {
            Console.WriteLine("Tiger is eating.");
        }
    }
    class Peacock : Tiger
    {
        public void eat()
        {
            Console.WriteLine("Peacock is eating.");
        }
    }
    class Dog : Peacock
    {
        public void eat()
        {
            Console.WriteLine("Dog is eating.");
        }
        public static void Main(string[] args)
        {
            Dog obj = new Dog();
            obj.eat();
            Console.ReadLine();
        }
    }

}