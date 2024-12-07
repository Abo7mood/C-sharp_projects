using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "I'm ";
            string str2 = "Game";
            string str3 = "Developer";
            string strAll = str1 +" "+ str2 + " " + str3;
            string strNames = "I'm" + " " + " Game" + " " + " Developer";
         
            string strNames2 = "I'm" +
                " " +
                " Game" +
                " " +
                " Developer";


            Console.WriteLine(strAll);
            Console.WriteLine(strNames);
        }
    }
}
