using System;

public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string speaker, int capacity, string title, string description, DateTime dateTime, string address) : base(title, description, dateTime, address)
    {
        _speakerName = speaker;
        _capacity = capacity;
    }

    public string GetSpeakerName()
    {
        return _speakerName;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public void DisplayLectureDetails()
    {
        Console.WriteLine($"Type: Lecture\nSpeaker : {_speakerName} \n{GetEventInfo()} \nCapacity: {_capacity}");
    }
}
