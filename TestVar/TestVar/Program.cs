using System;

namespace TestVar
{
    class Program
    {
       
        static void Main(string[] args)
        {
           
            sbyte number1;
            byte _byte = 5;
            long l = 405984590;
            ulong ll = 230923;
            short s = 3493;
            ushort ss= 12222;
            string B;
            char c;
            string F = "F";
            double Double = 3.149178052335676557667523567655766752384237;
            object O = 'A';
            decimal D = 4;
            int i = -99;
            uint ui = 99;
            bool b = true;
            number1 = -5;
            B = "Beauty";
            c = 'A';
            Console.WriteLine(number1+"sbyte");      
            Console.WriteLine(B + F+"Strings");                     
            Console.WriteLine(c+"char");
            Console.WriteLine(l+"l");
            Console.WriteLine(_byte + "byte");
            Console.WriteLine(s + "short");
            Console.WriteLine(ss + "ushort");
            Console.WriteLine(Double + "Double");
            Console.WriteLine(l + "long");
            Console.WriteLine(ll + "ulong");
            Console.WriteLine(O + "Object");
            Console.WriteLine(D + "Decimal");
            Console.WriteLine(i + "int");
            Console.WriteLine(ui + "uint");
            Console.WriteLine(b + "bool");

        }
    }
}
