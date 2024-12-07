using System;
using System.IO;


class Program
{
    static string path = @"d:\C#Scripts\SystemFiles\Test\";
    static string[] files = new string[10];
     
    static void Main(string[] args)
    {
        string x = "OR احب ال"+Environment.NewLine;
        try
        {
            for (int i = 0; i < files.Length; i++)
            {
                string fileName = path + "test" + i + ".txt";
                File.WriteAllText(fileName,x);
            }
           
           

        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message + " + look ! this error happen .");
        }


        finally
        {
            Console.WriteLine("Finally : Write");
        }
    }
}


