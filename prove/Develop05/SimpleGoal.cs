public class SimpleGoal : Goal
{
    public  SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
        
    }
    public SimpleGoal(StreamReader reader)
    {
    
    }
    public override void RecordEvent()
    {
        this._isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        throw new NotImplementedException();
    }
    public override string GetStringRepresentation()
    {
        string x = _isComplete ? "x" : " ";
        return $" [{x}] {_shortName}: {_description}, Points: {_points}";
    }
        internal new void WriteToStreamWriter(StreamWriter writer)
    {
        throw new NotImplementedException();
    }
}
    

