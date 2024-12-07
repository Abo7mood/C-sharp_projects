using System;

namespace ifComplicated2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region method1
            //Console.WriteLine("Hola");

            //string input = Console.ReadLine();
            //string[] languagearray = new string[2];
            //languagearray[0] = "English";
            //languagearray[1] = "Spanish";

            //input = (input == "Hi"||input=="hi") ? languagearray[0] :  languagearray[1];

            //Console.WriteLine(input);
            #endregion

            #region method2
            string[] Good = { "Nice !", "Go A head !", "You Are Good !" };
            string[] Bad = { "Try Again !", "No Problem !", "You can do this !" };
            #region int
            int min = 0;
            int max = 20;
            int result;
            int random1;
            int random2;
            #endregion
            #region random
            Random rand = new Random();
            random1 = rand.Next(min, max);
            random2 = rand.Next(min, max);
            result = random1 + random2;
            int randomResult = rand.Next(0, 3);

            Console.WriteLine("What is the result of :" + random1 + " + " + random2);


            int userResult = int.Parse(Console.ReadLine());

            string FinalResult = (userResult == result) ? Good[randomResult] : Bad[randomResult];

            Console.WriteLine(FinalResult);
            #endregion
            #endregion

            #region method3
            //int a=0;
            //int b=1;
            //string result;
            ////Level1
            //if (a > b)
            //{
            //    result = "Ok";
            //}
            //else
            //{
            //    result = "Bad";
            //}
            ////Level2
            //if (a > b)
            //    result = "Ok";
            //else
            //    result = "Bad";
            ////Level3
            //result = (a > b) ? "Ok" : "Bad";
            #endregion







        }
    }
}
