using NumberGuessGameConsoleApp.GuessGameReference;
using System;
using static NumberGuessGameConsoleApp.GuessGameReference.NumberGameGuessServiceClient;

namespace NumberGuessGameConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the main implementation of the service call. Here we will call the CheckNumber and SecretNumber operations
            // that are implemented in self - service hosting
            NumberGameGuessServiceClient numberGameGuessServiceClient = new NumberGameGuessServiceClient();
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.Write("Enter the Lower Limit");
            int lower = int.Parse(Console.ReadLine());
            Console.Write("Enter the Upper Limit");
            int upper = int.Parse(Console.ReadLine());
            // calling of the SecretNumber operation from service
            int secretNumber = numberGameGuessServiceClient.SecretNumber(lower, upper);
            bool guessedCorrectly = false;
            while (!guessedCorrectly)
            {
                // here we will ask the user to input the number to guess the secret number. It will ask untill correct number has been guessed.
                Console.Write("Enter your guess!");
                if(int.TryParse(Console.ReadLine(),out int guess))
                { 
                    // calling of the CheckNumber operation from service
                    string result = numberGameGuessServiceClient.CheckNumber(guess, secretNumber);
                    Console.WriteLine(result);
                    if (result == "Correct") guessedCorrectly = true;
                }
                else
                {
                    //It will throw an error message if the input is not an integer within the limits.
                    Console.WriteLine("Invalid input. Please enter a number");
                }
            }
            numberGameGuessServiceClient.Close();
            Console.WriteLine("Game Over. Press any key to exit.");
            Console.ReadLine();
        }
    }
}
