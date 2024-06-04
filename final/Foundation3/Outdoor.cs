using System;

public class Outdoor: Event
{
    private string _weatherForecast;
    // constructor
    public OutdoorGathering(string title, string description, DateTime date, Address address, string weatherForecast)
        : base(title, description, date, address)
    {
        _weatherForecast = weatherForecast;
    }

    public string GetOutDoorDetails()
    {
        return $"\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }
}