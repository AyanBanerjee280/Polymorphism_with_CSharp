using System;
namespace PolymorphismWithCsharp
{//Static Polymorphism or Compile time polymorphism is achieved by
//Method Overloading
//This is an example of Method Overloading
    class Method_Overloading
    {
        void sum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("{0}+{1}={2}", a,b,result);
        }
        void sum(float a, float b)
        {
            float result = a + b;
            Console.WriteLine("{0}+{1}={2}", a, b, result);
        }
        void sum(int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine("{0}+{1}+{2}={3}", a, b,c, result);
        }
        void sum(double a, double b)
        {
            double result = a + b;
            Console.WriteLine("{0} + {1} = {2}", a,b,result);
        }
        static void Main(string[] args)
        {
            Method_Overloading obj = new Method_Overloading();
            obj.sum(45, 5);
            obj.sum(41.325, 8.95);
            obj.sum(78, 94, 102);
            obj.sum(74d, 8d);
            Console.ReadLine();
        }
    }
}
