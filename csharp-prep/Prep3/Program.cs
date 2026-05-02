using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        // Initial magic number variable
        int magicNumber = Random.Shared.Next(1,101);

        // Guess loop
        int guess;
        do
        {
        string guessInput;
        Console.Write("What is your guess? ");
        guessInput = Console.ReadLine();
        guess = int.Parse(guessInput);
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        while (guess != magicNumber);
        
    }
}