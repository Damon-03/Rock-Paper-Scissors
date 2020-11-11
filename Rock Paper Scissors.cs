using System;

namespace Draft
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // loop so that when the game ends it can start again
            {
                bool loop = true; // loop for selecting Rock paper or Scissors
                Random random = new Random();
                // v Declaring Variables
                string computerInput = String.Empty;
                int computerChoice = 0;
                string userInput = string.Empty;
                int userChoice = 0;
                
                // Start of program
                while (loop)
                {
                    Console.WriteLine("Rock, Paper, or Scissors");
                    userInput = Console.ReadLine().ToLower();
                    // Couldn't find a quicker way to check if they inputted a correct answer
                    if (userInput == "rock" || userInput == "paper" || userInput == "scissors")
                    {
                        loop = false;
                        computerChoice = random.Next(3); // Generates a random number for what computer plays
                    }
                    else
                    {
                    }
                }
                switch (computerChoice) // Uses the random number to select paper, scissors or rock
                {
                    case 0:
                        computerInput = "paper";
                        computerChoice = 1;
                        break;
                    case 1:
                        computerInput = "scissors";
                        computerChoice = 10;
                        break;
                    case 2:
                        computerInput = "rock";
                        computerChoice = 100;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Computer plays " + computerInput); // Displays Computer's choice
                
                switch (userInput)
                {
                    case "paper":
                        userChoice = 1;
                        break;
                    case "scissors":
                        userChoice = 10;
                        break;
                    case "rock":
                        userChoice = 100;
                        break;
                }
                if (computerChoice == userChoice)
                {
                    Console.WriteLine("You have Tied:");
                }
                else if (userChoice == 1 && computerChoice == 100)
                {
                    Console.WriteLine("You Win: ");
                }
                else if (computerChoice == 1 && userChoice == 100)
                {
                    Console.WriteLine("CPU Wins: ");
                }
                else if (userChoice > computerChoice)
                {
                    Console.WriteLine("You Win: ");
                }
                else if (computerChoice > userChoice)
                {
                    Console.WriteLine("CPU Wins: ");
                }
                else
                    {
                    Console.WriteLine(computerChoice);
                    Console.WriteLine(computerInput);
                    Console.WriteLine(userChoice);
                    Console.WriteLine(userInput);
                    }
                Console.WriteLine("Continue: ");
                Console.ReadLine();
                
            }
        }
    }
}
