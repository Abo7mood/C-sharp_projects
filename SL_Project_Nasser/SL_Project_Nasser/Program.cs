using System;
using System.Collections.Generic;
namespace SL_Project_Nasser
{
    public static class StudentInformation
    {

        public static int QuestionType { get; set; }
        public static int ChapterType { get; set; }
        public static int SessionType { get; set; }

        public static int Score { get; set; }
    }
   public static class Helper
    {
        public static void ChangeColor(ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
        }
        public static int randomization(int x,int y)
        {
            Random r = new Random();
           int rand= r.Next(x, y);
            return rand;
        }
        public static void CheckInput(string Error,bool isTwo,bool isSession)
        {
            Helper.ChangeColor(ConsoleColor.Green);
            Data.choose = Console.ReadLine();
            F.Write("\n");
            while (!int.TryParse(Data.choose, out Data.num) || string.IsNullOrEmpty(Data.choose))
            {
                Helper.ChangeColor(ConsoleColor.Red);
                F.Write("Error : "+Error);
                Data.choose = Console.ReadLine();
            }

            while (int.TryParse(Data.choose, out Data.num))
            {
                if (int.Parse(Data.choose) != 1 && int.Parse(Data.choose) != 2 && int.Parse(Data.choose) != 3 && int.Parse(Data.choose) != 4 && int.Parse(Data.choose) != 5 || string.IsNullOrEmpty(Data.choose))
                {
                    Helper.ChangeColor(ConsoleColor.Red);
                    F.Write("Error : " + Error);
                    Data.choose = Console.ReadLine();
                }
                else break;

            }

            if (isSession) return;
            if (isTwo)
            {
                while (int.TryParse(Data.choose, out Data.num))
                {
                    if (int.Parse(Data.choose) != 1 && int.Parse(Data.choose) != 2 || string.IsNullOrEmpty(Data.choose))
                    {
                        Helper.ChangeColor(ConsoleColor.Red);
                        F.Write("Error : " + Error);
                        Data.choose = Console.ReadLine();
                    }
                    else break;

                }
            }
            else
            {
                while (int.TryParse(Data.choose, out Data.num))
                {
                    if (int.Parse(Data.choose) != 1 && int.Parse(Data.choose) != 2&&int.Parse(Data.choose) != 3 &&int.Parse(Data.choose) != 4 || string.IsNullOrEmpty(Data.choose))
                    {
                        Helper.ChangeColor(ConsoleColor.Red);
                        F.Write("Error : " + Error);
                        Data.choose = Console.ReadLine();
                    }
                    else break;

                }
            }

        }
    }
    public static class Data
    {
       public static int num = 0;
        public static int parse;
        public static string choose;
    }
   public class Start
    {

        #region init

        #endregion
        #region quesitons
        protected static string nameQuestion = "What is You'r Name :";
        protected static string nameInput;

        protected static List<char> nameInputList = new List<char>();
        #region Errors

        protected static string nameInputError = "Error : You'r name should not have any special characters" +
            " such as %$#! /numbers , or being empty !" ;

        static char[] symbols = { '$', '#', '!', '%' }; // the symobls characters , to check if your name is real or not 
        #endregion
        #endregion

        #region Check
        protected static bool isSpecial(string input)
        {
            bool isInt;
            bool isSpecial;

            int number = 0;

            isInt = int.TryParse(input, out number);
            isSpecial = nameInputList.Contains(symbols[0]) ||
                 nameInputList.Contains(symbols[1]) ||
                nameInputList.Contains(symbols[2]) ||
                nameInputList.Contains(symbols[3]) || input == "";
            return isInt || isSpecial;
        }
        protected static bool isInt(string input)
        {
            bool isInt;

            int number = 0;

            isInt = int.TryParse(input, out number);

            return isInt;
        }
        #endregion
        #region Functions


        #endregion
    }
   public static class F
    {
        public static void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
    class Base : Start
    {
     


       
        public void StartQuiz()
        {
            Helper.ChangeColor(ConsoleColor.Blue); // change color

            F.Write(nameQuestion+"\n"); // ask about he's name

            Helper.ChangeColor(ConsoleColor.Green);// change color

            nameInput = Console.ReadLine();// take username          
            ///add the characters to my list
            foreach (char nameinput in nameInput) nameInputList.Add(nameinput); // add character to my name
        }
        public void ChooseTest()
        {
            Helper.ChangeColor(ConsoleColor.Yellow);// change color

            F.Write("\n" + "Welcome : " + nameInput + "\n"); // say welcome to the user
           
           
            F.Write("You will take Pilot test for Computer Skills Book\n"); // let the user know what is this application
            Helper.ChangeColor(ConsoleColor.Blue);
            F.Write("Number 1 for General Test: " + "\n"); // let the user choose he's application prefrences            f.Write("Number 1 for General Test ", Console.ForegroundColor = ConsoleColor.Blue); // let the user choose he's application prefrences
            F.Write("Number 2 for Sessions Test: " + "\n"); // let the user choose he's application prefrences 
        }
        public void CheckAnswer()
        {
            Helper.CheckInput("Choose Between Number 1 and Number 2",true,false); // call the CheckInput Function

            Data.parse = int.Parse(Data.choose); // force the string to be an int
            StudentInformation.QuestionType = Data.parse; // set data
            QuestionsList.AskForType(); // call the AskForType Function

        }
        

    }


    class Result : Start
    {

        static void Main(string[] args)
        {
          
            #region Inititlize
            Base @base = new Base(); // Inititlize the class

            #endregion


            @base.StartQuiz(); // call the StartQuiz Function

            while (isSpecial(nameInput)|| string.IsNullOrEmpty(nameInput)) // check if he's name is real or not
            {
                Helper.ChangeColor(ConsoleColor.Red);// change color

                F.Write(nameInputError); // throw an error 

                for (int i = 0; i < nameInputList.Count; i++) nameInputList.RemoveAt(i); // delete all the symbols inside the list , reset it 

                Helper.ChangeColor(ConsoleColor.Green);// change color

                nameInput = Console.ReadLine(); // read user input again 
            }
            @base.ChooseTest();

            Helper.ChangeColor(ConsoleColor.Green);// change color

            @base.CheckAnswer(); // call the CheckAnswer Function

        }
    }

}
