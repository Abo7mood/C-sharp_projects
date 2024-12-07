using System;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Byte A;
            byte a;

            sbyte sb;
            SByte Sb;

            int ia;
            Int32 I32;

            UInt32 UI32;
            uint ui32;

            Int16 I16;
            short i16;

            UInt16 UI16;
            ushort ui16;

            Int64 I64;
            long i64;

            UInt64 UI64;
            ulong ul64;

            float s;
            Single S;

            double d;
            Double D;

            Char C;
            char c;

            bool b;
            Boolean B;

            object o;
            Object O;

            String St;
            string st;

            Decimal De;
            decimal de;
            #region Do while section
            //int abb = 2;
            //do
            //{
            //    abb++;
            //}
            //while (abb == 1);
            //Console.WriteLine(abb);
            #endregion
            #region while break and continue
            //for (int x = 1; x < 8; x++)
            //{
            //    if (x > 5)
            //        break;
            //    x--;
            //    x++;
            //    Console.WriteLine(x);
            //    Console.ReadLine();
            //    x--;
            //    Console.WriteLine(x);
            //}

            //for (int x = 0; x < 99; x++)
            //{
            //    if (x < 50)
            //        continue;
            //    Console.WriteLine(x);
            //}
            #endregion
            #region ?statement
            // int value=5;
            // int progress;
            //value =(value > 2) ? progress = 100 : progress = 2;
            // Console.WriteLine(progress);
            #endregion
            #region MyRegion
           
           
            int oldnumber=0;
            bool x = false;
            while (true)
            {
                int maxBid = Convert.ToInt32(Console.ReadLine());

                if (x == false)
                {
                    oldnumber = maxBid;
                }
                x = true;

                if (maxBid > oldnumber)
                    Console.WriteLine("Sold:"+ maxBid);


             

            }

            #endregion
        }
    }
}
