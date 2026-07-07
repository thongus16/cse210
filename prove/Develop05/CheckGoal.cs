class CheckGoal : SimpleGoal
{
    private int _bonus;
    private int _numComplete;
    private int _total;

    public CheckGoal(string title, string description, int points, bool completed, int bonus, int numComplete, int total) : base(title, description, points, completed)
    {
        _bonus = bonus;
        _numComplete = numComplete;
        _total = total;
    }

    public override string GetDisplayString()
    {
        int tempComplete = _numComplete;
        if (tempComplete > _total)
        {
            tempComplete = _total;
        }
        if (_completed)
        {
            return $"[X] {_title} ({_description}) -- Currently completed: {tempComplete}/{_total}";
        } else
        {
            return $"[ ] {_title} ({_description}) -- Currently completed: {tempComplete}/{_total}";
        }
        
    }

    public override string GetSaveString()
    {
        return $"CheckGoal:{_title}|{_description}|{_points}|{_completed}|{_bonus}|{_numComplete}|{_total}";
    }

    public override int Complete()
    {
        _numComplete++;
        if (_numComplete >= _total)
        {
            _completed = true;
        }
        if (_numComplete == _total)
        {
            return _points + _bonus;
        } else if (_numComplete < _total)
        {
            return _points;
        } else
        {
            return 0;
        }
    }
}