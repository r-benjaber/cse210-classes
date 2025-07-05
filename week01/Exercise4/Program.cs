using System;
using System.ComponentModel;
using System.Net.Sockets;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        //Declare list and variables
        List<int> numberList = new List<int>();
        string enteredNumber;
        int number = -1, largest = 0, sum = 0;
        float average;

        //Ask for the number
        while(number != 0)
        {
            Console.Write("Enter a number, enter 0 to finish: ");
            enteredNumber = Console.ReadLine();
            number = int.Parse(enteredNumber);

            //We add the number to the List if the number is different from 0
            if (number != 0)
            {
                numberList.Add(number);
            }
            
            //We add the number to the total
            sum += number;

            //Check and change if the number is the current largest
            if (number > largest)
            {
                largest = number;
            }
        }

        //Find the average
        average = ((float)sum) / numberList.Count;

        //Print everything
        Console.WriteLine($"The total is {sum}.");
        Console.WriteLine($"The average is {average}.");
        Console.WriteLine($"The largest is {largest}.");
    }
}