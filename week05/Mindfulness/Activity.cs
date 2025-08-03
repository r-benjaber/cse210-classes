using System.Runtime.CompilerServices;
using System.Web;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine(_description);
        Console.WriteLine("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(10);
    }

    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine("You did a Great Job.");
        Console.WriteLine($"You have completed the {_name}. Time spended: {_duration}");
        ShowSpinner(10);
    }

    public void ShowSpinner(int seconds)
    {
        int ticks = seconds * 1000;
        int count = 0;
        int skip = 250;
        // |/—\|/—\
        List<string> animationStrings = new List<string>{"|", "/", "—", "\\"};

        while (count < ticks)
        {
            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(skip);
                Console.Write("\b");
                count += skip;
                if (count >= ticks)
                {
                    break;
                }
            }
        }
    }

    public void ShowCountDown(int seconds) //Use only when the time is lesser than 10.
    {
        for (int i = seconds; i > 0; i--)
        {
            string iString = i.ToString();
            Console.Write(iString);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ShowDots(int seconds)
    {
        int ticks = seconds * 1000;
        int count = 0;
        int skip = 250;
        while (count < ticks)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(skip);
                count += skip;
            }
            Console.Write("\b\b\b   \b\b\b");
        }
    }

}