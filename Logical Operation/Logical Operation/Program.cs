using System;

namespace Logical_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool and1 = true && false;
            bool and2 = true && true;
            bool and3 = false && false;
            Console.WriteLine(and1);
            Console.WriteLine(and2);
            Console.WriteLine(and3);

            bool or1 = true || false;
            bool or2 = true || true;
            bool or3 = false || false;

            Console.WriteLine(or1);
            Console.WriteLine(or2);
            Console.WriteLine(or3);

            bool not1 = !true;
            bool not2 = !false;
            Console.WriteLine(not1);
            Console.WriteLine(not2);
        }
    }
}
