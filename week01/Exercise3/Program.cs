using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        //Creating the magic number.
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);

        //Guessing the magic number.
        bool guessed = false;
        int guess;
        string guessInput;

        while (guessed == false)
        {
            Console.Write("What is your guess: ");
            guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);
            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!!");
                guessed = true;
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower.");
            }
            else
            {
                Console.WriteLine("Higher.");
            }
        }
    }
}