using System;

namespace CompareOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 5;
            bool b;
            b = num1 == num2;
           bool b1 = num1 > num2;
            bool b2 = num1 >= num2;
            bool b3 = num1 <= num2;
            bool b4 = num1 != num2;
            Console.WriteLine(b+  "b");
            Console.WriteLine(b1 + "b1");
            Console.WriteLine(b2 + "b2");
            Console.WriteLine(b3 + "b3");
            Console.WriteLine(b4 + "b4");
        }
    }
}
