using System;

namespace If_Examples_you_know
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number 1 :");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 2 :");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine("Number 1 Bigger Than Number 2");
            else if (num1 < num2)
                Console.WriteLine("Number 1 smaller than Number 2");
            else
                Console.WriteLine("Number 1 equal Number 2");

            if(num1!=num2)
                Console.WriteLine("Number 1 not equal Number 2 ")

        }
    }
}
