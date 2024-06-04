using System;

// base class
public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private Address _address;

    // Constructor
    public Event(string title, string description, DateTime dateTime, Address address)
    {
        _title = title;
        _description = description;
        _date = dateTime;
        _address = address;
    }

    // Properties to access private attributes
    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public DateTime GetDateTime()
    {
        return _date;
    }


    
    public string GetEventInfo()
    {
        return $"Title: {_title} \nDescription: {_description}\nDate: {_date} \nAddress: {_address.GetFullAddress()}";
    }

}