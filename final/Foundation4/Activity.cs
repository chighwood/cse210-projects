using System;

public abstract class Activity
{
    protected DateTime _date;
    protected int _minutes;

    public Activity(DateTime date, int minutes)
    {
        this._date = date;
        this._minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"\n=================\n{_date:(d, MM, yyyy)}\n-------------\n{GetType().Name}\n-------------\nTime: ({_minutes} min)\n-------------\nDistance: {GetDistance():F2} miles\n-------------\nSpeed: {GetSpeed():F2} mph\n-------------\nPace: {GetPace():F2} min/mile\n=================";
    }
}
