using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convert From String to Int
            string Number1 = "999";
            int Number2 = 2;

            //Method 1: int r = int.Parse(Number1) + Number2;
            //Method 2: int r = Int32.Parse(Number1) + Number2;
           /*Method 3:*/ int r = Convert.ToInt32(Number1) + Number2;
            #region Convert 
            //Console.WriteLine(r);
            //Object IMObject = 99;
            //string IMSTRING = Convert.ToString(IMObject) + "MAMAMA";

            //Console.WriteLine(IMSTRING);
            //Console.ReadLine();
            //int imint = 66;
            //string imstring = "im a number";
            //string rr = Convert.ToString(imint) + imstring;
            //Console.WriteLine(rr);
            #endregion
            object obj = "Hello";

            //string str = obj; inCorrct

            string str = (string)obj; //Correct this is the cast

            double d = 2;
            // int i = d; inCorrect
         //   int i = int.Parse(d); inCorrect
           int i = Convert.ToInt32(d); //Correct

            double d1= 12.11;
            int i1 = Convert.ToInt32(d1);
            Console.WriteLine(i1);
          //Correct ! it will remove the .11 from the double cuz it is an integer
        }
    }
}
