using System;
namespace PolymorphismWithCsharp
{//Static Polymorphism or Compilr timr polymorphism is achieved by
//Method Overloading
//This is an example of Method Overloading
    class Types_Of_Method_Overloading
    {
        void mul(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("{0}+{1}={2}", a,b,result);
        }
        void mul(float a, float b)
        {//Method overloading by changing variable types
            float result = a * b;
            Console.WriteLine("{0}+{1}={2}", a, b, result);
        }
        void mul(int a, int b, int c)
        {//Method overloading by increasing number of paraters
            int result = a * b * c;
            Console.WriteLine("{0}+{1}+{2}={3}", a, b,c, result);
        }
        static void Main(string[] args)
        {
            Types_Of_Method_Overloading obj = new Types_Of_Method_Overloading();
            obj.mul(45, 5);
            obj.mul(41.325f, 8.95f);
            obj.mul(78, 94, 102);
            Console.ReadLine();
        }
    }
}
