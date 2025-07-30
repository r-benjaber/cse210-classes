using System.Reflection.Metadata;

public class Video
{
    private string _author;
    private string _title;
    private int _lenght;
    private List<Comment> _comments = new List<Comment>();

    public Video()
    {
        _author = "unknown";
        _title = "none";
        _lenght = 0;
    }

    public Video(string author, string title, int time)
    {
        _author = author;
        _title = title;
        _lenght = time;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{_author}'s {_title} ({_lenght}). Comments: {_comments.Count()}");
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetUser()}: {comment.GetText()}");
        }
    }

    public void DisplayAll()
    {
        DisplayInfo();
        DisplayComments();
        Console.WriteLine();
    }
}