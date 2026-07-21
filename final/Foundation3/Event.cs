using System.Runtime.InteropServices.Marshalling;

class Event
{
    private string _title;
    private string _desc;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string desc, string date, string time, Address address)
    {
        _title = title;
        _desc = desc;
        _date = date;
        _time = time;
        _address = address;
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"Title: {_title}, Description: {_desc}, Date: {_date}, Time: {_time}, Address: {_address.GetString()}");
    }

    public virtual void DisplayFullDetails()
    {
        this.DisplayStandardDetails();
        Console.WriteLine("Event Type: Event");
    }

    public virtual void DisplayShortDescription()
    {
        Console.WriteLine($"Event Type: Event, Title: {_title}, Date: {_date}");
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDate()
    {
        return _date;
    }
}