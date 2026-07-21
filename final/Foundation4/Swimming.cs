using System.Security.Cryptography.X509Certificates;

class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000;
    }

    public override double GetSpeed()
    {
        return (this.GetDistance() / this.GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return this.GetMinutes() / this.GetDistance();
    }

    public override string GetSummary()
    {
        return $"{this.GetDate()} Swimming ({this.GetMinutes()})- Distance: {this.GetDistance()} km, Speed: {this.GetSpeed()} kph, Pace: {this.GetPace()} min per km";
    }
}