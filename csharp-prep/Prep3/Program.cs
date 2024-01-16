using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        /*Console.Write("What is the magin number? ");
        int MagicNumber = int.Parse(Console.ReadLine());*/

        string playAgain = "yes";

        while (playAgain == "yes")
        {

            Random randomGenerator = new Random();
            int MagicNumber = randomGenerator.Next(1, 10);

            int guess = -1;
            int count = 0;

            while (MagicNumber != guess)
            {

                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                count += 1;


                if (guess < MagicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > MagicNumber)
                {
                    Console.WriteLine("Lower");
                }
            }

            Console.WriteLine($"You guessed it! It took you {count} guesses.");
            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();

        }

    }
}