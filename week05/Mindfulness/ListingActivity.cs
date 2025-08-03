using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Transactions;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine(GetRandomPromt());
        ShowDots(15);
        Console.WriteLine("Start Listing");
        List<string> respones = GetListFromUser();
        Console.WriteLine($"You thought about {_count} things");
        ShowSpinner(10);
        DisplayEndingMessage();

    }

    public string GetRandomPromt()
    {
        Random rnd = new Random();
        int i = rnd.Next(0, _prompts.Count());
        return _prompts[i];
    }

    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        List<string> responses = new List<string>();

        while (true)
        {
            DateTime currentTime = DateTime.Now;
            string response = Console.ReadLine();
            responses.Add(response);
            if (futureTime < currentTime) break;
        }
        _count = responses.Count();
        return responses;
    }
}