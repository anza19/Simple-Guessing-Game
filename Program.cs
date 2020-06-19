using System;

//container that holds functions and classesS
namespace NumberGuesser{

    //main class
    class Program{

        //entry point of our game
        static void Main(string[] args){

            //START HERE //
            
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Muhammad Anza Khan";

            //Change text colour
            Console.ForegroundColor = ConsoleColor.Cyan;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.WriteLine();

            //We reset the colour back to white
            Console.ResetColor();

            //Ask for user name
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("What is your name?");

            //Get user name
            string input = Console.ReadLine();
            Console.WriteLine("Hello, {0} let's play a game....", input);

            //We reset the colour back to white
            Console.ResetColor();
            Console.WriteLine();


            //Init the correct number
            int correctNumber = 7;

            //Ask user for a number
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Guess a number between 1 and 10");

            //Taking input from user
            int guessNumber = Convert.ToInt32(Console.ReadLine());

            //While it's not equal to the correct number
            while (guessNumber != correctNumber) {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Oooops! Try again!");

                //convert the string to int
                guessNumber = Convert.ToInt32(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct!");
            Console.ResetColor();
        }
    }
}
