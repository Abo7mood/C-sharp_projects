using System;

namespace AssigmentOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num1 = 5;
            Console.WriteLine(num1);
            Console.WriteLine( "+=5");
            num1 += 5;
            Console.WriteLine(num1);
            Console.WriteLine( "-=2");
            num1 -= 2;
            Console.WriteLine(num1 );
            Console.WriteLine( "*=2");
            num1 *= 2;
            Console.WriteLine(num1 );
            Console.WriteLine( "/=2");
            num1 /= 4;
            Console.WriteLine(num1 );
            Console.WriteLine( "%=2");
            num1 %= 3;
            Console.WriteLine(num1);

            Console.WriteLine("      ");
            string @string="";
            @string += "Ahmed";
            @string += " W W";
            Console.WriteLine(@string);


        }
    }
}
