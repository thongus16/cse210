class SimpleGoal
{
    protected string _title;
    protected string _description;
    protected int _points;
    protected bool _completed;

    public SimpleGoal(string title, string description, int points, bool completed)
    {
        _title = title;
        _description = description;
        _points = points;
        _completed = completed;
    }

    public virtual string GetDisplayString()
    {
        if (_completed)
        {
            return $"[X] {_title} ({_description})";
        } else
        {
            return $"[ ] {_title} ({_description})";
        }
        
    }

    public virtual string GetSaveString()
    {
        return $"SimpleGoal:{_title}|{_description}|{_points}|{_completed}";
    }

    public string GetTitle()
    {
        return _title;
    }

    public virtual int Complete()
    {
        if (!_completed)
        {
            _completed = true;
            return _points;
        } else
        {
            return 0;
        }
    }
}