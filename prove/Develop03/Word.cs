using System.Text.RegularExpressions;

class Word
{
    // Contains a single word, shouldn't contain spaces. Can contain punctuation such as commas or periods.
    private string _wordText;
    // Represents the current visibility of the word. If the word is visible, Display() will print _wordText. Otherwise, Display() will print _wordText with all letters replaced by an underscore.
    private bool _isVisible;

    // Creates a new word, populates _wordText with the parameter text, and initializes _isVisible to true.
    public Word(string text)
    {
        _wordText = text;
        _isVisible = true;
    }

    // Sets _isVisible to false.
    public void Hide()
    {
        _isVisible = false;
    }

    // Sets _isVisible to true.
    public void Show()
    {
        _isVisible = true;
    }

    // Returns _isVisible.
    public bool IsVisible()
    {
        return _isVisible;
    }

    // Prints _wordText. If _isVisible is false, all letters in _wordText are printed as underscores.
    public void Display()
    {
        if (_isVisible)
        {
            Console.Write(_wordText);
        } else
        {
            string hidText = _wordText;
            if (!_isVisible)
            {
                hidText = Regex.Replace(hidText, @"[a-zA-Z]", "_");
            }
            Console.Write(hidText);
        }
    }
}