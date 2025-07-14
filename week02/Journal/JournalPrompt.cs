//Bahaviors: Select random prompt
//Attributes: Prompt List

using System.Globalization;

public class JournalPrompt
{
    public List<string> _prompts;

    public string RandomPrompt()
    {
        Random rnd = new Random();
        string prompt = _prompts[rnd.Next(_prompts.Count)];
        return prompt;
    }
}