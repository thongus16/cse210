class Comment
{
    private string _author;
    private string _content;

    public Comment(string author, string content)
    {
        _author = author;
        _content = content;
    }

    public void GetString()
    {
        Console.WriteLine($"{_author}: {_content}");
    }
}