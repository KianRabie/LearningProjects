using System;
using System.Security.Cryptography;

namespace Number_Guesser
{
    public class Class1
    {
        public static void Main()
        {
            //Generates random number
            
            Random rnd = new Random();
            int rdmNum = rnd.Next(100);
            int guesses = 1;

            //Asks for user to input guess

            int guess;
            Console.WriteLine("Guess the random number!");
            var guessIn = Console.ReadLine();

            //Checks input is a number

            bool success = Int32.TryParse(guessIn, out guess);
            if (success)
            {
                if (guess > rdmNum)
                {
                    Console.WriteLine("Lower!");
                }

                if (guess < rdmNum)
                {
                    Console.WriteLine("Higher!");
                }
            }
            else Console.WriteLine("Feed me numbers!");

            //Checks if the guess was higher or lower



            //Loops until answer is guessed

            while (guess != rdmNum)
            {
                Console.WriteLine("Guess again!");

                guessIn = Console.ReadLine();

             //takes input and sees if its either higher or lower or exact
             //tells user if it was higher lower or exact

                success = Int32.TryParse(guessIn, out guess);
                if (success) ;
                else Console.WriteLine("Feed me numbers!");

                if (guess > rdmNum)
                {
                    Console.WriteLine("Lower!");
                }

                if (guess < rdmNum)
                {
                    Console.WriteLine("Higher!");
                }

                guesses ++;
            }

            //prints number of attempts once number is guessed

            if (guess == rdmNum)
            {
                Console.WriteLine("You got it! You guessed " +guesses+ " times!");
            }

        }
       




    }
}
