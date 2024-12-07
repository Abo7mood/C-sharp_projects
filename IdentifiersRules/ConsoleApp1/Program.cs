using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int  \u0003num; //Incorrect
            int num\u0033; //correct
            int INT; //Correct
            //يمكن استخدام الكلمات المحجوزه بحالة احرف اخرى ولكن لا ينصح بها

            string @string="Wow"; //Correct
            int @int = 55;
            Console.WriteLine(@int+ " int");
            Console.WriteLine(@string+ " string");
            //يمكن كتابه نفس اسم نوع المتغير بالضبط ولكن مع @ لكن لا ينصح بها

            //

        }
    }
}
