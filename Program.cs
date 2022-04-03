using System;

namespace FizzBuzz
{
    class Intro
    {
        static void Main()
        {

            Console.WriteLine("Have you played Fizz Buzz before? Type 'y' or 'n'.");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "y")
            {
                Console.WriteLine("Great, lets's begin!");
            }
            else if (answer.ToLower() == "n")
            {
                Console.WriteLine("To play Fizz Buzz, enter a number. If your number is divisible by 3 we'll say Fizz, " +
                    "is it's divisible by 5 we'll say Buzz, and if it's divisble by both we'll say Fizz Buzz.");
            }
            else
            {
                Console.WriteLine("Please give a valid input, 'y' or 'n'.");
            }
        }
    }
    class Play
    {
        static void Game()
        {
            Console.WriteLine("Enter your number.");
            int number = Convert.ToInt32(Console.ReadLine());
            if ((number % 3) & (number % 5) == 0)
            {
                Console.WriteLine("Fizz Buzz!");
            }
        }
    }
}

