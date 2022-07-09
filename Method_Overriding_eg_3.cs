using System;
namespace Polymorphism
{//This is an example of Run-time Polymorphism; also known as Method Overriding.
 //Method Overriding is achieved by the use of Inheritance.
    class Car
    {
        public void Price()
        {
            Console.WriteLine("Price is 900000.");
        }
    }
    class Maruti:Car
    {
        public void Price()
        {
            Console.WriteLine("Price is 1000000.");
        }
    }
    class Honda:Maruti
    {
        public void Price()
        {
            Console.WriteLine("Price is 1500000.");
        }
    }
    class Hyundai:Honda
    {
        public void Price()
        {
            Console.WriteLine("Price is 1900000.");
        }
    }
    class Mercedes:Hyundai
    {
        public void Price()
        {
            Console.WriteLine("Price is 20000000.");
        }
        public static void Main(string[] args)
        {
            Mercedes obj = new Mercedes();
            obj.Price();
            Console.ReadLine();
        }
    }

}