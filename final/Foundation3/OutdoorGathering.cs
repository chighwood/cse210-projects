using System;

public class OutdoorGathering : Event
{
    private static readonly string[] WeatherOptions = { "Sunny", "Raining", "Stormy", "Windy", "Cloudy", "Snowy" };

    private string _weatherForecast;


    public OutdoorGathering(string title, string description, DateTime dateTime, Address address) : base(title, description, dateTime, address)
    {
        Random random = new Random();
        int index = random.Next(WeatherOptions.Length);
        _weatherForecast = WeatherOptions[index];
    }

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() + $"\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }

    public override string GetShortDescription()
    {
        return $"Outdoor Gathering: {_title}, {_dateTime.ToShortDateString()}";
    }

}