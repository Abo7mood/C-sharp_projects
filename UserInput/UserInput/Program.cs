using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("WriteHere :");
            //string str=  Console.ReadLine();
            //Console.WriteLine("Input Is: " +str);

            //Console.Write("Enter Your Name : ");
            //string Name = Console.ReadLine();
            //Console.WriteLine("Welcome Mr :" + Name);


            Console.Write("Enter Number 1 : ");
            string strNum1 = Console.ReadLine();
            Console.Write("Enter Number 2 : ");
            string strNum2 = Console.ReadLine();
            int num1 = int.Parse(strNum1);
            int num2 = Convert.ToInt32(strNum2);
            int r = num1 + num2;
            Console.WriteLine(num1 + num2);
        }
    }
}
