using System;

class Program
{
    static void Main(string[] args)
    {
        // Variables
        string userGuess;
        int number;
        int guess;


        Random randomGenerator = new Random();
        number = randomGenerator.Next(1, 100);

        Console.Write("Pick a number between 1 and 100:  ");
        userGuess = Console.ReadLine();
        guess = int.Parse(userGuess);

        while (guess != number)
        {
            if (guess > number)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);
            }
        }
        Console.WriteLine("You guessed it!");
    }
}