using System.Transactions;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _comments = comments;
        _length = length;
    }

    public void GetString()
    {
        Console.WriteLine($"{_title} from {_author}, {_length} seconds long.");
    }

    public void GetComments()
    {
        foreach (Comment c in _comments)
        {
            c.GetString();
        }
    }

    public int GetNumComments()
    {
        return _comments.Count;
    }
}