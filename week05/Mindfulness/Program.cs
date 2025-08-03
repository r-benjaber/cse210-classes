using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        Console.WriteLine("Welcome to Mindfullness Activity, enter a number to start:");
        Console.WriteLine();
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        string response = Console.ReadLine();

        if (response == "1")
        {
            BreathingActivity activity = new BreathingActivity();
            activity.Run();
        }
        else if (response == "2")
        {
            ReflectionActivity activity = new ReflectionActivity();
            activity.Run();
        }
        else if (response == "3")
        {
            ListingActivity activity = new ListingActivity();
            activity.Run();
        }
    }
}