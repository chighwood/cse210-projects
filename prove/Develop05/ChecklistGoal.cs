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

    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            _isComplete = true;
            _points += _bonus;
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        return $"{GetStringRepresentation()}, Completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return GetDetailsString();
    }
        internal new void WriteToStreamWriter(StreamWriter writer)
    {
        throw new NotImplementedException();
    }
}
