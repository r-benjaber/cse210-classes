using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] notClassWords = text.Split(" ");
        foreach (string word in notClassWords)
        {
            Word w = new Word(word);
            _words.Add(w);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rnd = new Random();
        int c = 0;
        while (c != numberToHide && !IsCompletelyHidden())
        {
            int len = _words.Count;
            int rPos = rnd.Next(0, len);
            Word currentWord = _words[rPos];
            bool isHidden = currentWord.IsHidden();
            if (isHidden == false)
            {
                currentWord.Hide();
                c++;
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + ": ";
        foreach (Word word in _words)
        {
            displayText = displayText + word.GetDisplayText() + " ";
        }
        return displayText.TrimEnd();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}