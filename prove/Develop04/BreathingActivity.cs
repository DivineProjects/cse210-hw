using System;
using System.Threading; 

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        SetDuration();
        Console.Write("Get Ready ...");
        ShowSpinner(3);
        // initiate timer
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.WriteLine("");
        string[] breathe = { "Breathe in... ", "Breathe Out..." };
        int breatheIndex = 0;

        Console.WriteLine();
        while (DateTime.Now < endTime)
        {

            Console.Write(breathe[breatheIndex]);
            Thread.Sleep(2000);
            ShowCountDown(5);
            foreach (char c in breathe[breatheIndex])
            {
                Console.Write("\b"); // Backspace to overwrite character
            }
            breatheIndex = (breatheIndex + 1) % breathe.Length;
        }

        DisplayEndingMessage();

    }


}