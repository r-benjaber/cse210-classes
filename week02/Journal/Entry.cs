//Behaviors: display. 
//Attributes: Date and time, promp text, content.

public class Entry
{
    public string _now;
    public string _promptText;
    public string _text;

    public void Display()
    {
        Console.WriteLine(_promptText + " " + _now);
        Console.WriteLine(_text);
    }
}