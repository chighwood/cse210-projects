using System;

public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private DateTime _time;
    private Address _address;

    public Event(string title, string description, DateTime date, DateTime time, Address address)
    {
        this._title = title;
        this._description = description;
        this._date = date;
        this._time = time;
        this._address = address;
    }

    public string GetStandardDetails()
    {
        return $"Event Title: {_title} \nDescription: {_description} \nDate: {_date.ToShortDateString()} \nTime: {_time.ToShortTimeString()} \nAddress: {_address} ";
    }

    public abstract string GetFullDetails();

    public abstract string GetShortDescription();
}