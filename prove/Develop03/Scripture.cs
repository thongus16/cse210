class Scripture
{
    // Contains a list of Words, totaling together into the full text of the scripture.
    private List<Word> _scriptText;
    // Contains the relevant Reference of the scripture.
    private Reference _reference;

    // Creates a new Scripture with only one verse. text is turned into a list of Words, with space being the denominator.
    public Scripture(string text, string book, int chapter, int verse)
    {
        _reference = new Reference(book, chapter, verse);
        _scriptText = new List<Word>();
        GenerateWords(text);
    }
    // Creates a new Scripture with multiple verses. text is turned into a list of Words, with space being the denominator.
    public Scripture(string text, string book, int chapter, int startVerse, int endVerse)
    {
        _reference = new Reference(book, chapter, startVerse, endVerse);
        _scriptText = new List<Word>();
        GenerateWords(text);
    }

    // Populates _scriptText with Words.
    private void GenerateWords(string text)
    {
        string[] shlist = text.Split(' ');
        for (int i = 0; i < shlist.Length; i++)
        {
            Word word = new Word(shlist[i]);
            _scriptText.Add(word);
        }
    }

    // Attempts to change count amount of random Words to invisible. If it succeeds, it will return true. Otherwise, it will return false.
    public bool HideWords(int count)
    {
        Random rand = new Random();
        bool changed = false;
        for (int i = 0; i < count; i++)
        {
            List<int> refList = new List<int>();
            for (int j = 0; j < _scriptText.Count; j++)
            {
                if (_scriptText[j].IsVisible())
                {
                    refList.Add(j);
                }
            }
            if (refList.Count > 0)
            {
                _scriptText[refList[rand.Next(0, refList.Count)]].Hide();
                changed = true;
            } else
            {
                return changed;
            }
        }
        return true;
    }

    // Sets all Words to visible.
    public void ShowWords()
    {
        foreach (Word word in _scriptText)
        {
            word.Show();
        }
    }

    // Calls the Display() function of _reference and each Word in _scriptText, adding a space between each Word.
    public void Display()
    {
        _reference.Display();
        Console.Write(" ");
        for (int i = 0; i < _scriptText.Count - 1; i++)
        {
            _scriptText[i].Display();
            Console.Write(" ");
        }
        _scriptText[_scriptText.Count - 1].Display();
        Console.WriteLine("\n");
    }
}