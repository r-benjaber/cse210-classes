using System.Data.Common;
using System.Diagnostics.Tracing;
using System.Reflection;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference()
    {
        _book = "Unknown";
        _chapter = 1;
        _verse = 1;
        _endVerse = 1;
    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    public string GetDisplayText()
    {
        string displayText = "";
        if (_endVerse != _verse)
        {
            displayText = displayText + _book + " " + _chapter.ToString() + ":" + _verse.ToString() + "-" + _endVerse.ToString();
        }
        else
        {
            displayText = displayText + _book + " " + _chapter.ToString() + ":" + _verse.ToString();
        }
        return displayText;
    }
}