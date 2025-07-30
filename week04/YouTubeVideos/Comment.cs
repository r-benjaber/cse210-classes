using System.Reflection.Metadata;

public class Comment
{
    private string _user;
    private string _text;

    public Comment()
    {
        _user = "unknown";
        _text = "none";
    }

    public Comment(string user, string text)
    {
        _user = user;
        _text = text;
    }
    public string GetUser()
    {
        return _user;
    }

    public string GetText()
    {
        return _text;
    }
}