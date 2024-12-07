using System;

namespace _6wrni
{
    class Program
    {
        static void Main(string[] args)
        {

            char c1 = '\u0036';
            char c2 = '\u0057';
            char c3 = '\u0052';
            char c4 = '\u004E';
            char c5 = '\u0049';
            //Console.WriteLine(c1 + c2 + c3 + c4 + c5);
            string Name = "\u0036" + "\u0057" + "\u0052" + "\u004E" + "\u0049";
            Console.WriteLine(Name);
            Console.WriteLine(c5);
            string name2 = "\u0021";
            Console.WriteLine(name2);

        }
    }
}
