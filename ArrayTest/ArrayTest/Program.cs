using System;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region arrays
            //string[] classNames = { "Ahmed", "Nasser", "Khalid", "Yousef", };

            //for (int i = 0; i < classNames.Length; i++)
            //{
            //    Console.WriteLine(classNames[i]);
            //}
            //Console.ReadLine();
            //char[] chars = new char[5];
            //chars[0] = 'N';
            //chars[1] = 'A';
            //chars[2] = 'S';
            //chars[3] = 'E';
            //chars[4] = 'R';

            //for (int i = 0; i < chars.Length; i++)
            //{
            //    Console.WriteLine(chars[i]);
            //}
            //Console.ReadLine();

            //int[] num1 = { 1, 2, 3 };
            //num1[0]= 50;
            //num1[1] = 53;
            //num1[2] = num1[0] * num1[1];
            //Console.WriteLine(num1[2]);
            #endregion
            #region arrays count
            //string[] array = new string[4];
            //int arrayCount = array.Length;
            //Console.WriteLine(arrayCount);


            //int b=int.Parse(Console.ReadLine());

            //string[] array = new string[b];

            //string strName1 = "Ahmed";
            //array[array.Length - 1] = strName1;
            //Console.WriteLine(array.Length + strName1);


            //char[] chars = { 'N', 'A', 'S', 'S', 'E', 'R' };
            //Console.WriteLine(chars);

            //string strName = new string(chars);
            //Console.WriteLine(strName + "second");

            //string strName = "Ahmed";
            //char[] cName = strName.ToCharArray();
            //Console.WriteLine(cName);

            #endregion
            #region arraywithloop
            //string[] strNames = new string[5];
            //strNames[0] = "N";
            //strNames[1] = "A";
            //strNames[2] = "S";
            //strNames[3] = "S";
            //strNames[4] = "R";

            //for (int i = 0; i < strNames.Length; i++)
            //{
            //    Console.WriteLine(strNames[i]);
            //}

            //Console.Write("Enter Count Of Employess :");
            //int empCount = Convert.ToInt32(Console.ReadLine());
            //string[] strEmps = new string[empCount];



            //for (int i = 0; i < strEmps.Length; i++)
            //{
            //    Console.Write("Enter Emoloyess Number " +(i + 1)+" : ");
            //    strEmps[i] = Console.ReadLine();




            //}
            //for (int i = 0; i < strEmps.Length; i++)
            //{
            //    Console.WriteLine("   "+strEmps[i]);
            //}
            #endregion
            #region ArraywithForEach
            //string[] strNames = { "Amr", "Ali", "Nasser" };


            //foreach(string strName in strNames)
            //{
            //    Console.WriteLine(strName);
            //}

            string strName = "Nasser";
            foreach (char item in strName)
            {
                Console.Write(item);
            }

            #endregion


        }
    }
}
