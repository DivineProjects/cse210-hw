using System;

public class Outdoor : Event
{
    private string _weatherForecast;
    // constructor
    public Outdoor(string title, string description, DateTime date, Address address, string weatherForecast)
        : base(title, description, date, address)
    {
        _weatherForecast = weatherForecast;
    }

    public void DisplayOutDoorDetails()
    {
        Console.WriteLine($"\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast} \n{GetEventInfo()}");
    }
}