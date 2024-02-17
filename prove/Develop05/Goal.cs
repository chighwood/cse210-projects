using System.IO.Compression;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected int _pointsEarned;
    protected bool _isComplete;
    protected string reader;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
        _pointsEarned = 0;
        _isComplete = false;
    }
    public Goal()
    {

    }
     public int GetPoints()
    {
        return _points;
    }
    public int GetPointsEarned()
    {
        return _pointsEarned;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    public abstract void WriteToStreamWriter(StreamWriter writer);
}
