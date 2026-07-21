class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public virtual double GetDistance()
    {
        return 1000 / 1000;
    }

    public virtual double GetSpeed()
    {
        return (this.GetDistance() / this.GetMinutes()) * 60;
    }

    public virtual double GetPace()
    {
        return this.GetMinutes() / this.GetDistance();
    }

    public virtual string GetSummary()
    {
        return $"{this.GetDate()} Activity ({this.GetMinutes()})- Distance: {this.GetDistance()} km, Speed: {this.GetSpeed()} kph, Pace: {this.GetPace()} min per km";
    }
}