using System;

public class Reception: Event
{
    // Derived class for Reception events

    private string _rsvpEmail;
    // Constructor
    public Reception(string rsvpEmail, string title, string description, DateTime dateTime, string address) : base(title, description, dateTime, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public void DisplayReceptionDetails()
    {
        Console.WriteLine($"Email: {_rsvpEmail} \n{GetEventInfo()}");
    }
}