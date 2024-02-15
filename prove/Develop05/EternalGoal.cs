public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {
    
    }
    public override void RecordEvent()
    {
        return;
    }
    public override bool IsComplete()
    {
        // need code to check completion
        return false;
    }
    public override string GetDetailsString()
    {
        throw new NotImplementedException();
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName}: {_description}, Points: {_points}, Status: {_isComplete}"; 
    }
        internal new void WriteToStreamWriter(StreamWriter writer)
    {
        throw new NotImplementedException();
    }
}
