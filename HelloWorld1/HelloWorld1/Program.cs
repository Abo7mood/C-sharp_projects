using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld1
{

    class Program
    {
        public static string K = "Khaled";
        public static string D = "Dead";
        public static int age = 28;
        public static float PracticeTime = 7.5f;
        public static bool CanPractice = false;
        static void Main(string[] args)
        {
           
            a(5);
            Console.Title = "HI IM JASON";
            Console.ForegroundColor = ConsoleColor.Red;
          
            CanWalk();
           
          
            Console.Read();
           

        }
        public static int a (int khaledAge)
            {
            khaledAge = age;
            
            return khaledAge;

            }
        public static void CanWalk()
        {
            CanPractice = true;

            if (CanPractice == true)
            {
                age = 28;
                PracticeTime = 7.5f;
                Console.WriteLine(K);
                Console.WriteLine(age);
                Console.WriteLine(PracticeTime);
                Console.ReadLine();
                CanPractice = false;
            }
            else if(CanPractice==false)
            {
                age = 50;
                PracticeTime = 3.55f;
                Console.WriteLine(D);
                Console.WriteLine(age);
                Console.WriteLine(PracticeTime);
                Console.ReadLine();
            }
        }

    }
}
































































//    for (int i = 0; i < count; i += 1)

//        if (i % 2 == 0)
//        {
//            level += 1;
//            min = min * 2;
//            max = max * 2;

//    x = rand.Next(min, max);
//    y = rand.Next(min, max);



//    Console.ForegroundColor = ConsoleColor.Gray;


//    Console.WriteLine($"level: <{level}> {x} - {y}=?");
//    if (Console.ReadLine() == (x - y).ToString())
//    {

//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine("yaldafoor! ");
//        score += 1;
//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("yalsbkk!");
//    }

//}
//        Console.ForegroundColor = ConsoleColor.Gray;
//        Console.Write($"n8a6k:");
//        if (score == count)
//        {
//            Console.ForegroundColor = ConsoleColor.Green;
//        }
//        else
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//        }
//        Console.WriteLine($"{score}/{count}");
//        Console.ReadLine();
