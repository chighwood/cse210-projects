public class EternalGoal : Goal
{
    int _amountCompleted;
    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {
        _amountCompleted = 0;
    }
    public EternalGoal(StreamReader reader)
    {
        _shortName = reader.ReadLine();
        _description = reader.ReadLine();
        _points = int.Parse(reader.ReadLine());
        _pointsEarned = int.Parse(reader.ReadLine());
        _amountCompleted = int.Parse(reader.ReadLine());
        _isComplete = bool.Parse(reader.ReadLine()); 
    }
    public override void RecordEvent()
    {
        _pointsEarned += _points;
        _amountCompleted++;
        return;
    }
    public override bool IsComplete()
    {
        // need code to check completion
        return false;
    }
    public override string GetStringRepresentation()
    {
        string complete = _amountCompleted > 0 ? "-" : " ";
        return $"[{complete}] {_shortName}: {_description}, Points: {_points}, Status: completed {_amountCompleted} times"; 
    }
    public override void WriteToStreamWriter(StreamWriter writer)
    {
        writer.WriteLine(_shortName);
        writer.WriteLine(_description);
        writer.WriteLine(_points);
        writer.WriteLine(_pointsEarned);
        writer.WriteLine(_amountCompleted);
        writer.WriteLine(_isComplete);
    }
}
