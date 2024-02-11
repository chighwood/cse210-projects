public class ChecklistGoal : Goal{

    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base (target, bonus)
    {
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        // implement recording event
    }
    public new bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()}, Completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return GetDetailsString();
    }
}