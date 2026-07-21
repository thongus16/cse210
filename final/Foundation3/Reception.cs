class Reception : Event
{
    private string _email;

    public Reception(string title, string desc, string date, string time, Address address, string email) : base(title, desc, date, time, address)
    {
        _email = email;
    }

    public override void DisplayFullDetails()
    {
        this.DisplayStandardDetails();
        Console.WriteLine($"Event Type: Reception, RSVP: {_email}");
    }

    public override void DisplayShortDescription()
    {
        Console.WriteLine($"Event Type: Reception, Title: {this.GetTitle()}, Date: {this.GetDate()}");
    }
}