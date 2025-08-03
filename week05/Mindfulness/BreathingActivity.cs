using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks.Dataflow;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        int ticks = _duration * 1000;
        int counter = 0;
        while (counter < ticks)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            Console.Write("\nHold your breath... ");
            ShowCountDown(7);
            Console.Write("\nBreathe out... ");
            ShowCountDown(8);
            Console.WriteLine();
            counter += 19000;
        }
        DisplayEndingMessage();
    }
}