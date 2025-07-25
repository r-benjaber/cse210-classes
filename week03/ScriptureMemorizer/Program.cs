using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference ref1 = new Reference("John", 3, 16);
        Scripture scr1 = new Scripture(ref1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        while (!scr1.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scr1.GetDisplayText());
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            scr1.HideRandomWords(2);
        }
        Console.Clear();
    }
}