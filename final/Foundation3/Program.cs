using System;

class Program
{
    static void Main(string[] args)
    {
        
        // instances of each event type
        Lecture lecture = new Lecture(
            "Dr. Khumalo",100, "Trade", 
            "A talk on trade roots in the 1950s.",
            new DateTime(2024, 6, 10, 18, 0, 0),
            new Address("123 Cutural Road", "Bulawayo", "BYO", "Zimbabwe")
            
        );

        Reception reception = new Reception(
            "rsvp@event.com","Artifact Fundraiser",
            "Fund raiising for the presevation of 10 century artifacts",
            new DateTime(2024, 7, 09, 19, 0, 0),
            new Address("789 Fund Avenue", "Midrand", "GP", "South Africa")
            
        );

        Outdoor outdoorGathering = new Outdoor(
            "Music Gala",
            "Music, dance, food and drink besides the lake",
            new DateTime(2024, 6, 20, 10, 0, 0),
            new Address("456 Music Street", "Lusaka", "LK", "Zambia"),
            "Sunny"
        );

        // // Generate and print marketing messages for each event
        Console.Clear();
        Console.WriteLine("\n========= Event: Lecture ========================");
        lecture.DisplayLectureDetails();
        Console.WriteLine("\n========= Event: Reception ======================");
        reception.DisplayReceptionDetails();
        Console.WriteLine("\n========= Event: Outdoor Gathering ==============");
        outdoorGathering.DisplayOutDoorDetails();
    }
}