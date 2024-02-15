using System.IO.Compression;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
        _isComplete = false;
    }
    public int GetPoints()
    {
        return _points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();

    internal void WriteToStreamWriter(StreamWriter writer)
    {
        throw new NotImplementedException();
    }
}
