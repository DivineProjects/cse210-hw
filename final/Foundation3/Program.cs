using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("Divine",20, "Big Bang Theory","the old universe", DateTime.Now, "10742");
        // Console.WriteLine("lecturer: " + lecture.GetSpeakerName());
        // Console.WriteLine(lecture.GetEventInfo());

        lecture.DisplayLectureDetails();

        Reception reception = new Reception("dd@gmail.com", "Big Bang Theory","the old universe", DateTime.Now, "10742");
        reception.DisplayReceptionDetails();
    }
}