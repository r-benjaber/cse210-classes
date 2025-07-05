using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        //First we declare the variables
        string firstName, lastName;

        //We prompt the user to write its name and last name
        Console.Write("What is your first name? ");
        firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        lastName = Console.ReadLine();

        //We print it all together
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}