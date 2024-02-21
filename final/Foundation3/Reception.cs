using System;

public class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime dateTime, Address address, string rsvpEmail) : base(title, description, dateTime, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() + $"\nType: Reception\nRSVP Email: {rsvpEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Reception: {_title}, {_dateTime.ToShortDateString()}";
    }
}