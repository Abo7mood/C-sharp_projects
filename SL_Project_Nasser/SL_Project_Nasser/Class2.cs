using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL_Project_Nasser
{
    public static class QuestionsList
    {
        #region init
        static Questions questions = new Questions();
        static Question question = new Question();
        #endregion

        #region varibles
        const int QUESTIONS_NUMBER_GENERAL = 10; // how many question we have , total questions
        const int QUESTIONS_NUMBER_SESSION = 3; // how many question we have , total questions

        public static int questionCount = 0; // loop throw general questions
        public static int sessionLoop = 0; // loop throw session questions

        public static int sessionCount = 0; // loop throw qusetion dictonary



        static string questionChoose;

        const int S1_MIN = 0, S1_MAX = 9, S2_MIN = 9, S2_MAX = 17, S3_MIN = 17, S3_MAX = 26, S4_MIN = 26, S4_MAX = 35, S5_MIN = 35, S5_MAX = 44;

        #endregion

        public static Dictionary<int, QuestionsData> sessionList = new Dictionary<int, QuestionsData>();


        public static void QuestionFunction(int questionNumber)
        {
            questionChoose = Console.ReadLine();

            F.Write("Choose the correct answer : ");
            F.Write(questions.questions[questionNumber].Type);
            F.Write(questions.questions[questionNumber].Question);
            F.Write(questions.questions[questionNumber].Answers);

            while (!int.TryParse(questionChoose, out Data.num))
            {
                F.Write("Error : Choose Numbers between 1-4");
                questionChoose = Console.ReadLine();
            }
            Data.parse = int.Parse(questionChoose);
            if (Data.parse == questions.questions[questionNumber].Answer)
                StudentInformation.Score++;

        }

        #region Private
        public static void AskForType()
        {
            ///here we are taking the input , to give the user questions depend on what he choose
            switch (Data.parse)
            {
                case 1:
                    //loop throw my questions number to give the user specefic questions count
                    for (questionCount = 0; questionCount < QUESTIONS_NUMBER_GENERAL; questionCount++)
                    {
                        ///check if questions is null + reroll

                        question.GeneralTest(); // call the GeneralTest Function
                    }

                    break;
                case 2:
                    ChooseSession();  // call the ChooseSession Function
                    break;
                default:

                    F.Write("ERROR");

                    break;
            }
        }
        #endregion
        private static void ChooseSession()
        {
            ///let user choose the quesition
            F.Write("Choose your Session\n");

            F.Write("Number 1 for Session 1");
            F.Write("Number 2 for Session 2");
            F.Write("Number 3 for Session 3");
            F.Write("Number 4 for Session 4");
            F.Write("Number 5 for Session 5");

            Helper.CheckInput("Error : Choose Number 1 , or Number 2,or Number 3,or Number 4,,or Number 5", true, true);
            Data.parse = int.Parse(Data.choose); // force the string to be an int





            switch (Data.parse)
            {
                case 1:
                    for (sessionCount = 0; sessionCount < questions.questions.Count; sessionCount++)
                    {
                        if (questions.questions[sessionCount].Session == 1)
                            sessionList.Add(sessionCount, questions.questions[sessionCount]);
                        else continue;
                    }
                    for (sessionLoop = 0; sessionLoop < QUESTIONS_NUMBER_SESSION; sessionLoop++)
                        question.SessionTest(1, S1_MIN, S1_MAX);

                    break;
                case 2:
                    for (sessionCount = 0; sessionCount < questions.questions.Count; sessionCount++)
                    {
                        if (questions.questions[sessionCount].Session == 2)
                            sessionList.Add(sessionCount, questions.questions[sessionCount]);
                        else continue;

                    }

                    for (sessionLoop = 0; sessionLoop < QUESTIONS_NUMBER_SESSION; sessionLoop++)
                        question.SessionTest(2, S2_MIN, S2_MAX);
                    //session test
                    break;

                case 3:
                    for (sessionCount = 0; sessionCount < questions.questions.Count; sessionCount++)
                    {
                        if (questions.questions[sessionCount].Session == 3)
                            sessionList.Add(sessionCount, questions.questions[sessionCount]);

                    }

                    for (sessionLoop = 0; sessionLoop < QUESTIONS_NUMBER_SESSION; sessionLoop++)
                        question.SessionTest(3, S3_MIN, S3_MAX);
                    //session test
                    break;
                case 4:
                    for (sessionCount = 0; sessionCount < questions.questions.Count; sessionCount++)
                    {
                        if (questions.questions[sessionCount].Session == 4)
                            sessionList.Add(sessionCount, questions.questions[sessionCount]);

                    }
                    for (sessionLoop = 0; sessionLoop < QUESTIONS_NUMBER_SESSION; sessionLoop++)
                        question.SessionTest(4, S4_MIN, S4_MAX);
                    //session test
                    break;
                case 5:
                    for (sessionCount = 0; sessionCount < questions.questions.Count; sessionCount++)
                    {
                        if (questions.questions[sessionCount].Session == 5)
                            sessionList.Add(sessionCount, questions.questions[sessionCount]);

                    }

                    for (sessionLoop = 0; sessionLoop < QUESTIONS_NUMBER_SESSION; sessionLoop++)
                        question.SessionTest(5, S5_MIN, S5_MAX);
                    //session test
                    break;
                default:
                    break;
            }



        }
    }
    public class Question : Start
    {
        #region init

        Questions questions = new Questions(); //initizlize
        #endregion

        #region Lists
        int questionNumber;


        const int QUESTIONS_NUMBER = 10;// how many question we have , total questions
        const int QUESTIONS_NUMBER_SESSION = 3; // how many question we have , total questions



        #endregion

        public void GeneralTest()
        {
            while (!questions.questions.ContainsKey(questionNumber))
            {
                questionNumber = Helper.randomization(0, QUESTIONS_NUMBER); //give the user random questions from my list 
            }

            ///write the question details
            ///
            Helper.ChangeColor(ConsoleColor.Blue);
            F.Write("Choose the correct answer : \n");
            Helper.ChangeColor(ConsoleColor.Yellow);
            F.Write(questions.questions[questionNumber].Type + ":" + "\n");
            F.Write(questions.questions[questionNumber].Question + "\n");
            F.Write(questions.questions[questionNumber].Answers + "\n");

            if (questions.questions[questionNumber].Type == "complete the sentences  \n \n")
            {
                Helper.CheckInput(" Choose Number 1 , or Number 2,or Number 3,or Number 4", false, false);
            }
            else
            {
                Helper.CheckInput(" Choose Number 1 , or Number 2", true, false);
            }
            ///check if he answer right 
            if (Data.choose == questions.questions[questionNumber].Answer.ToString())
            {
                Helper.ChangeColor(ConsoleColor.Green);//change color
                F.Write("Correct !");
                F.Write("\n");
                StudentInformation.Score++;
            }
            ///, otherwise he will get an error
            else
            {
                Helper.ChangeColor(ConsoleColor.Red);//change color
                F.Write("Wrong , The Real Answer is : " + questions.questions[questionNumber].AnswerName);
            }

            questions.questions.Remove(questionNumber);  //remove the question so he can't see the same question twice

            questionNumber = -1; // reset the question index

            if (QuestionsList.questionCount >= QUESTIONS_NUMBER - 1)
            {
                F.Write(nameInput + "\n");
                Helper.ChangeColor(ConsoleColor.Yellow);
                Console.Write("Mark : ");
                Helper.ChangeColor(ConsoleColor.Green);
                F.Write(StudentInformation.Score.ToString() + "/" + QUESTIONS_NUMBER);

                Helper.ChangeColor(ConsoleColor.Yellow);
                F.Write("Thanks for participating : " + nameInput);
            }
        }
        public void SessionTest(int sessionNumber, int min, int max)
        {

            while (!QuestionsList.sessionList.ContainsKey(sessionNumber))
            {

                sessionNumber = Helper.randomization(min, max); //give the user random questions from my list 
            }

            ///write the question details
            ///
            Helper.ChangeColor(ConsoleColor.Blue);
            F.Write("Choose the correct answer : \n");
            Helper.ChangeColor(ConsoleColor.Yellow);
            F.Write(QuestionsList.sessionList[sessionNumber].Type + ":" + "\n");
            F.Write(QuestionsList.sessionList[sessionNumber].Question + "\n");
            F.Write(QuestionsList.sessionList[sessionNumber].Answers + "\n");

            if (QuestionsList.sessionList[sessionNumber].Type == "complete the sentences , \n \n")
            {
                Helper.CheckInput(" Choose Number 1 , or Number 2,or Number 3,or Number 4", false, false);
            }
            else
            {
                Helper.CheckInput(" Choose Number 1 , or Number 2", true, false);
            }
            ///check if he answer right 
            if (Data.choose == QuestionsList.sessionList[sessionNumber].Answer.ToString())
            {
                Helper.ChangeColor(ConsoleColor.Green);//change color
                F.Write("Correct !");
                F.Write("\n");
                StudentInformation.Score++;
            }
            ///, otherwise he will get an error
            else
            {
                Helper.ChangeColor(ConsoleColor.Red);//change color
                F.Write("Wrong , The Real Answer is : " + QuestionsList.sessionList[sessionNumber].AnswerName);
            }

            QuestionsList.sessionList.Remove(sessionNumber);  //remove the question so he can't see the same question twice

            sessionNumber = -1; // reset the question index

            if (QuestionsList.sessionLoop >= QUESTIONS_NUMBER_SESSION - 1)
            {
                F.Write(nameInput + "\n");
                Helper.ChangeColor(ConsoleColor.Yellow);
                Console.Write("Mark : ");
                Helper.ChangeColor(ConsoleColor.Green);
                F.Write(StudentInformation.Score.ToString() + "/" + QUESTIONS_NUMBER_SESSION);

                Helper.ChangeColor(ConsoleColor.Yellow);
                F.Write("Thanks for participating : " + nameInput);
            }
        }


    }
}
