using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime dateTime, Address address, string speaker, int capacity) : base (title, description, dateTime, address)
    {
        this._speaker = speaker;
        this._capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() + $"\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    public override string GetShortDescription()
    {
        return $"Lecture: {_title}, {_dateTime.ToShortDateString()}";
    }
}