using RobTheBank_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobTheBank_Console
{
    public class ProgramUI
    {
        BankRepository _repo = new BankRepository(); //just like when our ProgramUI is instantiated, two fields inside our _repo are instantiated, and not disposed of until this ProgramUI class is disposed once our ConsoleApp stops running
        void SeedQuestionList()

        {
            Questions questionOne = new Questions();
            questionOne.QuestionDescription = "What time would be best to rob a bank?";
            questionOne.Question = 1;
            questionOne.AnswerOne = "1.) Morning";
            questionOne.AnswerTwo = "2.) Afternoon";
            questionOne.AnswerThree = "3.) Night";

            Questions questionTwo = new Questions();
            questionTwo.QuestionDescription = "What weapon would you use to rob the bank?";
            questionTwo.Question = 2;
            questionTwo.AnswerOne = "1.) Knife";
            questionTwo.AnswerTwo = "2.) Bomb";
            questionTwo.AnswerThree = "3.) Gun";

            Questions questionThree = new Questions();
            questionThree.QuestionDescription = "How many members would you have on your crew?";
            questionThree.Question = 3;
            questionThree.AnswerOne = "1.) 1";
            questionThree.AnswerTwo = "2.) 2";
            questionThree.AnswerThree = "3.) 4";

            Questions questionFour = new Questions();
            questionFour.QuestionDescription = "Choose your method of escape!";
            questionFour.Question = 4;
            questionFour.AnswerOne = "1.) Hot Air Baloon";
            questionFour.AnswerTwo = "2.) Private Jet";
            questionFour.AnswerThree = "3.) Moped";



            _repo.AddQuestionsToList(questionOne);
            _repo.AddQuestionsToList(questionTwo);
            _repo.AddQuestionsToList(questionThree);
            _repo.AddQuestionsToList(questionFour);

            Responses one = new Responses("Too Early", "1.) Morning");
            Responses two = new Responses("Too Many People", "2.) Afternoon");
            Responses three = new Responses("Just Right - Proceed to next question", "3.) Night");
            Responses four = new Responses("Pocket Knife isn't Big Enough!", "1.) Knife");
            Responses five = new Responses("Perfect Solution - Very Scary - Proceed to next question", "2.) Bomb");
            Responses six = new Responses("No Bullets!", "3.) Gun");
            Responses seven = new Responses("All by Yourself!", "1.) 1");
            Responses eight = new Responses("You and Your Best Friend?", "2.) 2");
            Responses nine = new Responses("Enough Peope to Provide 2 on Lookout and 2 to Carry the Money - Proceed to next question", "3.) 4");
            Responses ten = new Responses("Hot Air Ballon, UP UP and Away - Success!!!!", "1.) Hot Air Baloon");
            Responses eleven = new Responses("You Spent the Money too Soon!", "2.) Private Jet");
            Responses twelve = new Responses("Too Many People for One Moped!", "3.) Moped");

            _repo.AddResponseToList(one);
            _repo.AddResponseToList(two);
            _repo.AddResponseToList(three);
            _repo.AddResponseToList(four);
            _repo.AddResponseToList(five);
            _repo.AddResponseToList(six);
            _repo.AddResponseToList(seven);
            _repo.AddResponseToList(eight);
            _repo.AddResponseToList(nine);
            _repo.AddResponseToList(ten);
            _repo.AddResponseToList(eleven);
            _repo.AddResponseToList(twelve);
          

        }
        public void Run()
        {
            SeedQuestionList();
            RunMenu();

        }
        public void RunMenu()
        {
            Console.WriteLine("You are playing ROB THE BANK\n" +
                 "  \n" +
                "Rules of the game:\n" +
                "  \n" +
                "Read each question and respond with whatever number is positioned next to your desired answer\n" +
                 "  \n" +
                "Example: \n" +
                 "  \n" +
                "What is your favorite color:\n" +
                "1. Green\n" +
                 "  \n" +
                "Answer = 1 \n" +
                "  \n" +
                "Press Any Key to Continue..."
                );
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("What is your name?: \n" +
                "  \n" +
                "");
            Player oneGuy = new Player();
            oneGuy.Name = Console.ReadLine();
            string interpol = $"Well, well, well, {oneGuy.Name}, let's see if you can rob a bank and get away with it! \n" +
                $"";
            Console.WriteLine(interpol);
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadKey();
            

            int numberVariable = 1;
            
            bool gameOn = true;

            while (gameOn)
            {
                string shortResponse;
                Console.Clear();
                string reply = NewQuestion(numberVariable);
                switch (numberVariable)
                {
                    case 1:

                         if (reply == "1")
                         { 
                            // shortResponse = "1.) Morning";
                            ReadResponse("1.) Morning");
                        }
                         if (reply == "2")
                         {
                            //shortResponse = "2.) Afternoon";
                            ReadResponse("2.) Afternoon");
                        }
                         if (reply == "3")
                         {
                            //shortResponse = "3.) Night";
                            ReadResponse("3.) Night");
                            numberVariable = 2;
                         }
                         if (reply != "1" && reply != "2" && reply != "3")
                         {
                            
                            Console.WriteLine(" Try Again - number must be 1,2,or 3!");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        if (reply == "1")
                        {
                            // shortResponse = "1.) Morning";
                            ReadResponse("1.) Knife");
                        }
                        if (reply == "2")
                        {
                            //shortResponse = "2.) Afternoon";
                            ReadResponse("2.) Bomb");
                            numberVariable = 3;
                        }
                        if (reply == "3")
                        {
                            //shortResponse = "3.) Night";
                            ReadResponse("3.) Gun");
                        }
                        if (reply != "1" && reply != "2" && reply != "3")
                        {
                            Console.WriteLine(" Try Again - number must be 1,2,or 3!");
                            Console.ReadKey();
                        }
                        //ReadResponse(shortResponse);
                        break;
                    case 3:
                        if (reply == "1")
                        {
                            // shortResponse = "";
                            ReadResponse("1.) 1");
                        }
                        if (reply == "2")
                        {
                            //shortResponse = "";
                            ReadResponse("2.) 2");
                        }
                        if (reply == "3")
                        {
                            //shortResponse = "";
                            ReadResponse("3.) 4");
                            numberVariable = 4;
                        }
                        if (reply != "1" && reply != "2" && reply != "3")
                        {
                            Console.WriteLine(" Try Again - number must be 1,2,or 3!");
                            Console.ReadKey();
                        }
                        //ReadResponse(shortResponse);
                        
                        break;
                    case 4:
                        if (reply == "1")
                        {
                            // shortResponse = "";
                            ReadResponse("1.) Hot Air Baloon");
                            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                            Console.WriteLine(" !!! You are READY to Rob the Bank !!!");
                            Console.ReadKey();
                            gameOn = false;
                        }
                        if (reply == "2")
                        {
                            //shortResponse = "";
                            ReadResponse("2.) Private Jet");
                        }
                        if (reply == "3")
                        {
                            //shortResponse = "";
                            ReadResponse("3.) Moped");
                        }
                        if (reply != "1" && reply != "2" && reply != "3")
                        {
                            Console.WriteLine(" Try Again - number must be 1,2,or 3!");
                            Console.ReadKey();

                        }
                        //ReadResponse(shortResponse);
                        break;
                    default:
                        gameOn = false;
                        break;
                }
            }

            string NewQuestion(int number)
            {

                Questions questioninfo = _repo.GetQuestionByNumber(number);
                Console.WriteLine(questioninfo.QuestionDescription);
                Console.WriteLine(questioninfo.AnswerOne);
                Console.WriteLine(questioninfo.AnswerTwo);
                Console.WriteLine(questioninfo.AnswerThree);
                string reply = Console.ReadLine();
                return (reply);
            }
            void ReadResponse(string description)
            {
                Responses responseinfo = _repo.GetResponsesByNumber(description);
                Console.WriteLine(responseinfo.Answer);
                Console.WriteLine(responseinfo.Response);

                Console.ReadKey();
            }
           


        }
    }
}
