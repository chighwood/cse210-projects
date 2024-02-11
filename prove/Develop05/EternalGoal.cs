public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base (name, description, points)
    {
        _isComplete = false;
    }
    public override void RecordEvent()
    {
        //Implementaition for recording event
    }
    public override bool IsComplete()
    {
        // need code to check completion
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName}: {_description}, Points: {_points}, Status: {_isComplete}"; 
    }
}