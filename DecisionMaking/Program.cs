using System;

namespace DecisionMaking
{
    class Program
    {
        public static int GenerateSecret()
        {
            Random generator = new Random();
            return generator.Next(1, 5);
        }

        public static int RequestUserGuess()
        {
            Console.WriteLine("Please enter a guess [1,4]: ");
            int guess = Convert.ToInt32(Console.ReadLine());
            return guess;
        }

        public static void EvaluateUserGuess(int secret, int userGuess)
        {
            if (secret == userGuess)
            {
                Console.WriteLine("Congratz. You guessed it right");
            }
            else if (secret < userGuess)
            {
                Console.WriteLine("Sorry you missed it.");
                Console.WriteLine("You guessed to high");
                Console.WriteLine("The secret was " + secret);
            }
            else
            {
                Console.WriteLine("Sorry you missed it.");
                Console.WriteLine("You guessed to low");
                Console.WriteLine("The secret was " + secret);
            }

            //else
            //{
            //    Console.WriteLine("Sorry you missed it.");
            //    if (secret < userGuess)
            //    {
            //        Console.WriteLine("You guessed to high");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You guessed to low");
            //    }
            //    Console.WriteLine("The secret was " + secret);
            //}
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to number guesser");

            int secret = GenerateSecret();

            int userGuess = RequestUserGuess();

            EvaluateUserGuess(secret, userGuess);

        }
    }
}
