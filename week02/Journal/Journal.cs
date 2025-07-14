//Save in file, load from file, display entries, add entry.
//Attributes: List of entries
using System.IO;


public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }
    public string _fileName;

    public void SaveInFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {

            foreach (Entry ent in _entries)
            {
                outputFile.WriteLine(ent._promptText + "|" + ent._now + "|" + ent._text);
            }

        }
    }

    public void LoadFromFile()
    {
        string[] lines = File.ReadAllLines(_fileName);
        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry ent = new Entry();
            ent._promptText = parts[0];
            ent._now = parts[1];
            ent._text = parts[2];

            _entries.Add(ent);
        }
    }

    public void AddEntry(Entry ent)
    {
        _entries.Add(ent);
    }

    public void DisplayAll()
    {
        foreach (Entry ent in _entries)
        {
            ent.Display();
        }
    }
}