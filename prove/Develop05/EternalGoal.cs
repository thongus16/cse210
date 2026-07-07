using System.Drawing;

class EternalGoal : SimpleGoal
{
    public EternalGoal(string title, string description, int points, bool completed) : base(title, description, points, completed)
    {
        
    }

    public override string GetDisplayString()
    {
        return $"[ ] {_title} ({_description})";
    }

    public override string GetSaveString()
    {
        return $"EternalGoal:{_title}|{_description}|{_points}|{_completed}";
    }

    public override int Complete()
    {
        return _points;
    }
}