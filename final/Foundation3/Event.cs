using System;

public abstract class Event
{
    protected string _title;
    protected string _description;
    protected DateTime _dateTime;
    protected Address _address;

    public Event(string title, string description, DateTime dateTime, Address address)
    {
        this._title = title;
        this._description = description;
        this._dateTime = dateTime;
        this._address = address;
    }

    public string GetStandardDetails()
    {
        return $"Event Title: {_title} \nDescription: {_description} \nDate: {_dateTime.ToShortDateString()} \nTime: {_dateTime.ToShortTimeString()} \nAddress: {_address} ";
    }

    public abstract string GetFullDetails();

    public abstract string GetShortDescription();
}