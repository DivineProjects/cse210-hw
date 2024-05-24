using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "\n\nThis activity will help you relax by walking you through breathing in and out slowly. \nClear your mind and focus on your breathing.", 9)
    {

    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.Write("\nHow long, seconds would you like for this activity?: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Write("Get Ready ...");
        ShowSpinner(3);
        // initiate timer
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        // DateTime currentTime = ;

        string[] breathe = { "Breathe in...", "Breathe Out..." };
        int breatheIndex = 0;

        Console.WriteLine();
        while (DateTime.Now < endTime)
        {
            
            Console.Write(breathe[breatheIndex]);
            Thread.Sleep(1000);
            ShowCountDown(5);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b"); // Backspace to overwrite spinner character
            breatheIndex = (breatheIndex + 1) % breathe.Length;
        }

        DisplayEndingMessage();

    }


}