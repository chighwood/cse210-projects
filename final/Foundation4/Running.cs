using System;

public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        this._distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (_minutes / 60.0);
    }

    public override double GetPace()
    {
        return _minutes / _distance;
    }
}