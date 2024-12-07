using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char c1 = '\u004e';
            char c2 = '\u0041';
            char c3 = '\u0053';
            char c4 = '\u0053';
            char c5 = '\u0045';
            char c6 = '\u0052';
            Console.WriteLine("MY NAME IS : " + c1+c2+c3+c4+c5+c6);

            string MYNAME;
            MYNAME = "\u004e\u0041\u0053\u0053\u0045\u0052";
            Console.WriteLine("MY NAME IS String : " + MYNAME);
        }
    }
}
