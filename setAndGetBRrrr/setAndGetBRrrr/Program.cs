using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] numbers = new int[5];

    //        int count = 0;
    //        while (count < 5)
    //        {
    //            numbers[count] = Convert.ToInt32(Console.ReadLine());
    //            count++;
    //        }
    //        //your code goes here
    //        int total = 0;
    //        for (int i = 0; i < numbers.Length; i++)
    //        {
    //            if (numbers[i] % 2 != 0) continue;
    //            total += numbers[i];
    //        }
    //        Console.WriteLine(total);
    //        Console.ReadLine();
    //    }
    //}
    //class MultipleArrays
    //{
    //    static void Main(string[] args)
    //    {

    //        //2d array
    //        int[,] numbers = { { 1, 2 }, { 5, 3 } };

    //        for (int i = 0; i < 2; i++)
    //        {
    //            break;
    //            for (int x = 0; x < 2; x++)
    //            {
    //                Console.WriteLine(numbers[i,x]);

    //            }
    //        }
    //        //3d array
    //        int[,,] numbers2 = { { { 13, 2 }, { 16, 42 }, { 8, 2 } }, { { 6, 3}, { 77, 5}, { 1, 25 } } };
    //        for (int x = 0; x < 2; x++)
    //        {
    //            for (int y = 0; y < 3; y++)
    //            {
    //                for (int z = 0; z < 2; z++)
    //                {
    //                    Console.WriteLine(numbers2[x,y,z] + " ");
    //                }
    //            }
    //        }

    //    }
    //}
    //    class JaggedArrays
    //    {
    //        static void Main(string[] args)
    //        {

    //            int[][] jaggedArr = new int[][]
    //{
    //  new int[ ] {1,8,2,7,9},
    //  new int[ ] {2,4,6},
    //  new int[ ] {33,42}
    //};






    //        }
    //    }

    //class JaggedArrayQuestion
    //{
    //    static void Main(string[] args)
    //    {
    //        int day1Winner = Convert.ToInt32(Console.ReadLine());
    //        int day2Winner = Convert.ToInt32(Console.ReadLine());
    //        int day3Winner = Convert.ToInt32(Console.ReadLine());


    //        string[][] olympiad = new string[][]
    //        {
    //            //day 1 - 5 participants
    //            new string[] { "Jill Yan", "Bridgette Ramona", "Sree Sanda", "Jareth Charlene", "Carl Soner" },
    //            //day 2 - 7 participants
    //            new string[] { "Anna Hel", "Mariette Vedrana", "Fran Mayur", "Drake Hilmar", "Nikolay Brooks", "Eliana Vlatko", "Villem Mario" },
    //            //day 3 - 4 participants
    //            new string[] { "Hieremias Zavia", "Ziya Ollie", "Christoffel Casper", "Kristian Dana", }

    //        };
    //        Console.WriteLine(olympiad[0][day1Winner-1]);
    //        Console.WriteLine(olympiad[1][day2Winner - 1]);
    //        Console.WriteLine(olympiad[2][day3Winner - 1]);


    //    }
    //}

    //class test
    //{


    //   static void Main(string[] args)
    //    {

    //        int[] input = new int[5];
    //        int min = 1000000;
    //        int max = 1;
    //        for (int i = 0; i < input.Length; i++)
    //        {
    //            input[i] = Convert.ToInt32(Console.ReadLine());

    //        }
    //        for (int i = 0; i < input.Length; i++)
    //        {
    //            if (min >= input[i])
    //            min = input[i];

    //            if (max < input[i])
    //                max = input[i];
    //        }
    //        Console.WriteLine(min + max);
    //        Console.WriteLine(min + " min");
    //        Console.WriteLine(max + " max");

    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string s = "SoloLearn is awesome";
    //        Console.Write(s.IndexOf('e'));

    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int count = 0;

            //your code goes here
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(letter))
                {
                    count++;
                    Console.WriteLine(words[i]);
                    
                }
                   
            }
            if (count > 0) return;
            Console.WriteLine("No match");
        }
    }
}