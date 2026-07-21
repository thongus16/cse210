class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed / 60) * this.GetMinutes();
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return this.GetMinutes() / this.GetDistance();
    }

    public override string GetSummary()
    {
        return $"{this.GetDate()} Cycling ({this.GetMinutes()})- Distance: {this.GetDistance()} km, Speed: {this.GetSpeed()} kph, Pace: {this.GetPace()} min per km";
    }
}