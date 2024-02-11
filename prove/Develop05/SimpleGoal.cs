public class SimpleGoal : Goal
{
    private bool _isComplete;

    public  SimpleGoal(string name, string description, string points) : base (name, description, points)
    {
        _isComplete = false;
    }
    public void RecordEvent()
    {
        // Implement recording event
    }
    public bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName}: {_description}, Points: {_points}, Status: {_isComplete}";
    }
}