class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string desc, string date, string time, Address address, string weather) : base(title, desc, date, time, address)
    {
        _weather = weather;
    }

    public override void DisplayFullDetails()
    {
        this.DisplayStandardDetails();
        Console.WriteLine($"Event Type: Outdoor, Weather: {_weather}");
    }

    public override void DisplayShortDescription()
    {
        Console.WriteLine($"Event Type: Outdoor, Title: {this.GetTitle()}, Date: {this.GetDate()}");
    }
}