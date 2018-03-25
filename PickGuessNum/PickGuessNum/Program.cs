// Application_Name     : PickGuessNum
// Objective            : Implement iteration using if else-if, do-while statements 
//                      : that will select a number to print or guess a number that has been randomly generated
// Programmer           : billint
// Date                 : 14th March 2017

using System; // This is the package we need to execute this script. The additional packages 
              // can stay be we aren't gonna use them for this application

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickGuessNum
{
    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // variable set to true. While true, display menu
            bool digitsMenu = true;

            while (digitsMenu)
            {
                digitsMenu = MainMenu();
            }
        }

        // Options menu will appear allowing user to print or guess numbers and exit
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Console... Not just a place, but a?? State Of Mind!!!"); // not that funny
            Console.WriteLine("[Play-My-Digits]");
            Console.WriteLine("1) Print-Em-Digits...");
            Console.WriteLine("2) Play - Guess-My-Digits!!!");
            Console.WriteLine("3) Goodbye");

            // User must select a choice
            string result = Console.ReadLine();
            if (result == "1") // 1) Game Num 1: Printing number
            {
                PrintDigits();
                return true;
            }
            else if (result == "2") // 2) Game Two 2: Guessing number
            {
                GuessMyDigits();
                return true;
            }
            else if (result == "3") // 3) Exit 
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        // If user selects game 1) they select a num and it counts to current value
        private static void PrintDigits()
        {
            Console.Clear();
            Console.WriteLine("Print Digits!");
            Console.Write("Show My Digit: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result + 1)
            {
                Console.Write(counter);
                Console.Write("-"); // for example, selecting 3 will print 1-2-3
                counter++;
            }
            Console.ReadLine();
        }

        private static void GuessMyDigits()
        {
            Console.Clear();
            Console.WriteLine("Guess A Digit!");

            // Random num generator in dotnet framework - produces sequence of numbers based on our algorithm
            Random aRandom = new Random();
            int randNum = aRandom.Next(1, 11);
            int guesses = 0;
            bool incorrect = true;
            // do-while statement to implement iteration. Program selects random num and user must guess
            do
            {
                Console.WriteLine("Guess a digit between 1 and 10: ");
                string result = Console.ReadLine();
                guesses++;

                if (result == randNum.ToString())
                {
                    // Boolean
                    incorrect = false;
                }
                else
                {
                    // If num doesn't match randomly generated number, print message to user
                    Console.WriteLine("Wrong Digit... Keep Going!");
                }
                
            } while (incorrect);

            // User selects the num that program generated
            Console.WriteLine("BINGO! Thats my digit! It only took {0} guesses.", guesses);

            Console.ReadLine();
        }
    }
}
