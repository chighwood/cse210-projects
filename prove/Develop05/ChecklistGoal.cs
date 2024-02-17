public class ChecklistGoal : Goal{

    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(StreamReader reader)
    {
        _shortName = reader.ReadLine();
        _description = reader.ReadLine();
        _points = int.Parse(reader.ReadLine());
        _pointsEarned = int.Parse(reader.ReadLine());
        _isComplete = bool.Parse(reader.ReadLine());
        _amountCompleted = int.Parse(reader.ReadLine());
        _target = int.Parse(reader.ReadLine());
        _bonus = int.Parse(reader.ReadLine()); 
    }
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _amountCompleted++;
            _pointsEarned += _points;
        }
        if (!_isComplete && _amountCompleted == _target)
        {
            _isComplete = true;
            _pointsEarned += _bonus;
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        string x = "";
        if (!_isComplete && _amountCompleted > 0)
        {
            x = "-";
        }
        else if (_isComplete)
        {
            x = "x";
        }
        else
        {
            x = " ";
        }
        return $"[{x}] {_shortName}: {_description}, Points: {_points}, Progress: {_amountCompleted}/{_target}";
    }
        public override void WriteToStreamWriter(StreamWriter writer)
    {
        writer.WriteLine(_shortName);
        writer.WriteLine(_description);
        writer.WriteLine(_points);
        writer.WriteLine(_pointsEarned);
        writer.WriteLine(_isComplete);
        writer.WriteLine(_amountCompleted);
        writer.WriteLine(_target);
        writer.WriteLine(_bonus);
    }
}
