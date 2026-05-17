public class Entry()
{
    public string _prompt; // the prompt the user answered
    public string _response; // the anwser to the prompt
    public string _date; // the date the Entry was recorded

    // displays the contents of Entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_response}");
    }
}