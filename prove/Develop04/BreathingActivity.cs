using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "\nThis activity will help you relax by walking you through breathing in and out slowly. \nClear your mind and focus on your breathing.", 9)
    {

    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        Console.Clear();
        DisplayStartingMessage();
        // DateTime currentTime = ;
        while (DateTime.Now < futureTime)
        {
            
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe Out...");
            Console.Clear();
        }
        DisplayEndingMessage();

    }


}