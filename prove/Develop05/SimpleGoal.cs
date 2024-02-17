public class SimpleGoal : Goal
{
    public  SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
        
    }
    public SimpleGoal(StreamReader reader)
    {
        _shortName = reader.ReadLine();
        _description = reader.ReadLine();
        _points = int.Parse(reader.ReadLine());
        _pointsEarned = int.Parse(reader.ReadLine());
        _isComplete = bool.Parse(reader.ReadLine()); 
    }
    public override void RecordEvent()
    {
        _pointsEarned += _points;
        this._isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        string x = _isComplete ? "x" : " ";
        return $"[{x}] {_shortName}: {_description}, Points: {_points}";
    }
        public override void WriteToStreamWriter(StreamWriter writer)
    {
        writer.WriteLine(_shortName);
        writer.WriteLine(_description);
        writer.WriteLine(_points);
        writer.WriteLine(_pointsEarned);
        writer.WriteLine(_isComplete);
    }
}
    

