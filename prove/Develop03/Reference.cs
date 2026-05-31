class Reference
{
    // Contains the name of the book of the scripture.
    private string _book;
    // Contains the chapter number of the scripture.
    private int _chapter;
    // Contains the first verse from the scripture.
    private int _startVerse;
    // Contains the last verse from the scripture. If there is only one verse, _endVerse will be the same as _startVerse.
    private int _endVerse;

    // Creates a new Reference with only one verse.
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }
    // Creates a new Reference that spans a group of verses.
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // Prints the Reference in a "Book Chapter: Verse" format. If there are multiple verses, a "Book Chapter: Start-End" format will be used instead.
    public void Display()
    {
        if (_startVerse == _endVerse)
        {
            Console.Write($"{_book} {_chapter}: {_startVerse}");
        } else
        {
            Console.Write($"{_book} {_chapter}: {_startVerse}-{_endVerse}");
        }
    }
}