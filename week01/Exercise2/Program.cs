using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        //Ask the user for the grade percentage.
        Console.Write("Enter your score: ");
        string scoreInput = Console.ReadLine();
        int score = int.Parse(scoreInput);

        //Print out the letter grade.
        string grade;
        if (score >= 90)
        {
            grade = "A";
        }
        else if (score >= 80)
        {
            grade = "B";
        }
        else if (score >= 70)
        {
            grade = "C";
        }
        else if (score >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is {grade}");

        //Print if approved
        if (grade == "D" || grade == "F")
        {
            Console.WriteLine("Not Passed. You can try again.");
        }
        else
        {
            Console.WriteLine("You passed. Congrats.");
        }
    }
}