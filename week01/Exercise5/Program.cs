using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Enter your favorite number: ");
        string userInput = Console.ReadLine();
        int favoriteNumber = int.Parse(userInput);
        return favoriteNumber;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }

    static void Main(string[] args)
    {
        string name;
        int number, square;

        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        name = PromptUserName();
        number = PromptUserNumber();
        square = SquareNumber(number);
        DisplayResult(name, square);
    }
}