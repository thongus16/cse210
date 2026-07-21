class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / this.GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return this.GetMinutes() / _distance;
    }

    public override string GetSummary()
    {
        return $"{this.GetDate()} Running ({this.GetMinutes()})- Distance: {this.GetDistance()} km, Speed: {this.GetSpeed()} kph, Pace: {this.GetPace()} min per km";
    }
}