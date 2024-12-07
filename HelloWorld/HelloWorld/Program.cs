using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
       struct Question
        {

            public int X;
           public int Y;
            public string Operator;
               public int Result;

        }
       
       static Question GetAQuestion(int level)
       {
            var rand = new Random();
            var q = new Question();
            int x, y;


            switch (level)
            {
                case 1:
                    x = rand.Next(5, 10);
                    y = rand.Next(10, 20);
                    q.X = x;
                    q.Y = y;
                    q.Operator = "+";
                    q.Result = x + y;
                    break;
                case 2:
                    x = rand.Next(20, 50);
                    y = rand.Next(20, 50);
                    q.X = x;
                    q.Y = y;
                    q.Operator = "+";
                    q.Result = x + y;
                    break;

                case 3:
                    x = rand.Next(1, 12);
                    y = rand.Next(12, 24);
                    q.X = x;
                    q.Y = y;
                    q.Operator = "-";
                    q.Result = y - x;
                    break;
                //x = rand.Next(1, 12);
                //y = rand.Next(1, 12);
                //q.X = x;
                //q.Y = y;
                //q.Operator = "X";
                //q.Result = x * y;
                //break;

                case 4:
                    x = rand.Next(12, 24);
                    y = rand.Next(24, 50);
                    q.X = x;
                    q.Y = y;
                    q.Operator = "-";
                    q.Result = y - x;
                    break;

                
                case 5:
                    x = rand.Next(1, 12);
                    y = rand.Next(1, 12);
                    q.X = x;
                    q.Y = y;
                    q.Operator = "X";
                    q.Result = x * y;
                    break;
                case 6:
                    x = rand.Next(12, 24);
                    y = rand.Next(12, 24);
                    q.X = x;
                    q.Y = y;
                    q.Operator = "X";
                    q.Result = x * y;
                    break;
                
                case 7:
                    x = rand.Next(1,12);
                    y = rand.Next(12,24);
                    q.X = x;
                    q.Y = x * y;
                    q.Operator = "/";
                    q.Result = y;
                    break;

                case 8:
                    x = rand.Next(12, 24);
                    y = rand.Next(24,48);
                    q.X = x;
                    q.Y = x * y;
                    q.Operator = "/";
                    q.Result = y;
                    break;
                case 9:
                    x = rand.Next(50, 100);
                    y = rand.Next(100, 200);
                    q.X = x;
                    q.Y = y;
                    q.Operator = "X";
                    q.Result = x * y;
                    break;

                case 10:
                    x = rand.Next(200, 400);
                    y = rand.Next(400, 1000);
                    q.X = x;
                    q.Y = y;
                    q.Operator = "+";
                    q.Result = x + y;
                    break;

            }




            return q;
                
        } 
        
            
           
        static void Main(string[] args)
        {
            
           
           
            
            var score = 0;
            Console.WriteLine("7iak allah fe a5tbar alraithiat");

            
            var count = 20;
            var level = 0;
            
            
            for (int i = 0; i < count; i += 1)


            {
               
                if (i % 2 == 0)
                {
                    level += 1;
                }
                var question = GetAQuestion(level);



                Console.ForegroundColor = ConsoleColor.Gray;





                Console.WriteLine($"level: <{level}> {question.X} {question.Operator} {question.Y}=?");
                if (Console.ReadLine() == (question.Result).ToString())
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("yaldafoor! ");
                    score += 1;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("yalsbkk!");



                }


            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($"n8a6k:");
            if (score == count)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine($"{score}/{count}");
            Console.ReadLine();
            


       

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
