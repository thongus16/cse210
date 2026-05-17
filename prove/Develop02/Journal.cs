using System.IO;

public class Journal()
{
    public List<Entry> _entries = new List<Entry>(); // a list of all entries stored in this journal

    // appends an Entry to _entries
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // save _entries to a csv file
    public void SaveJournal(string file)
    {
        using(StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._prompt}|{entry._response}|{entry._date}");
            }
        }
    }

    // overwrites _entries with the contents of a csv file
    public void LoadJournal(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._prompt = parts[0];
            entry._response = parts[1];
            entry._date = parts[2];
            this.AddEntry(entry);
        }
    }

    // iterates through _entries and calls the Dispaly() function of each Entry
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
}