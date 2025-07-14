using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Net.Quic;
using System.Threading.Tasks.Dataflow;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        int menuQuitChoice = 5, choice = -1;
        Journal journal = new Journal();
        JournalPrompt prompt = new JournalPrompt();
        prompt._prompts = new List<string>
        {
            "What made you smile today?",
            "What did you learn about yourself today?",
            "What are you grateful for right now?",
            "What challenge did you face today and how did you handle it?",
            "Describe a moment that made you feel at peace.",
            "What would you like to improve about yourself?",
            "If you could relive one moment from today, what would it be and why?",
            "How did you show kindness today?",
            "What's one small victory you had today?",
            "What emotion did you feel the most today?",
            "What did I learn from my scripture study today?",
            "How did I feel the Spirit today?",
            "What did I learn in church this week that impacted me?",
            "How have I seen God's hand in my life today?",
            "What principle of the Gospel do I need to apply more fully?",
            "Who did I serve today? How did it make me feel?",
            "How can I strengthen my testimony this week?",
        };

        while (choice != menuQuitChoice)
        {
            choice = DisplayMenu();
            MenuFunctionality(choice, journal, prompt);
        }
    }

    static int DisplayMenu()
    {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            choice = -1;
        }

        return choice;
    }

    static void MenuFunctionality(int choice, Journal journal, JournalPrompt prompt, int write = 1, int display = 2, int save = 3, int load = 4, int quit = 5)
    {
        if (choice == write)
        {
            MenuWrite(journal, prompt);
        }
        else if (choice == display)
        {
            journal.DisplayAll();
        }
        else if (choice == save)
        {
            Console.WriteLine("What's the name of the file you want to save in? ");
            string fileName = Console.ReadLine();
            journal._fileName = fileName + ".txt";
            journal.SaveInFile();
        }
        else if (choice == load)
        {
            Console.WriteLine("What's the name of the file you want to load from? ");
            string fileName = Console.ReadLine();
            journal._fileName = fileName + ".txt";
            journal.LoadFromFile();
        }
        else if (choice == quit)
        {
            return;
        }
        else
        {
            Console.WriteLine("Not a valid option.");
        }
    }

    static void MenuWrite(Journal journal, JournalPrompt prompt)
    {
        Entry ent = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        ent._promptText = prompt.RandomPrompt();
        ent._now = theCurrentTime.ToShortDateString();
        Console.WriteLine(ent._promptText + " " + ent._now);
        ent._text = Console.ReadLine();
        journal.AddEntry(ent);
    }
}
