using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();
            
            while (true)
            {
                Random random = new Random();

                // set correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for a number
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    // Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number...");

                        // keep going
                        continue;
                    }

                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, Please try again..");
                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();
            
                if(answer == "Y")
                {
                    continue;
                }else if(answer == "N")
                {
                    return;
                } else
                {
                    return;
                }
            }
        }
        
        static void GetAppInfo()
        {
            // app vars
            string appName = "Number Guesser";
            string version = "1.0.0";
            string author = "Jonathan Walumbe";

            // change consoke color
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, version, author);

            Console.ResetColor();
        }

        static void GreetUser()
        {
            // Ask user name
            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Let's play a game...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    
    }
}
