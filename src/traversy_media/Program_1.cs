using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            
            GetAppInfo(); // Run GetAppInfo function to get info

            GreetUser(); // Ask for users name and greet

            while(true) {

              
                // create a new Random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");
                while(guess != correctNumber) {
                    // get user input
                    string input = Console.ReadLine();

                    // Cast to int and put in guess
                    //guess = Int32.Parse(input);
                    // make sure its a number
                    if(!int.TryParse(input, out guess)) {
                        
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        // keep going
                        continue;
                    }

                    // Match guess to correct number
                    if (guess != correctNumber) {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }


                }

                    

            
                
                PrintColorMessage(ConsoleColor.Yellow, "Correct, you guessed it!");

                // ask to play again
                Console.WriteLine("Play Again? [Y or N]");
                // get answer
                string answer = Console.ReadLine().ToUpper();
                
                
                if(answer == "Y") {
                    continue;
                } else if (answer == "N") {
                    return;
                } else {
                    return;
                }
            }

        }

        static void GetAppInfo(){
            string appName = "NumberGuesser";
            string appVersion = "1.0.0";
            string appAuthor = "Brad Traversy";
            
            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        static void GreetUser() {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message) {
            // Change text color
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}