using System;
using System.Threading;


public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void SetDuration()
    {
        Console.Write("\nEnter the duration of the activity (in seconds): ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine(_description);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell Done!!!!!");
        ShowSpinner(4);
        Console.WriteLine($"You have completed another {_duration} seconds of {_name} Activity");
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        string[] spinner = { "|", "/", "-", "\\"};
        int spinnerIndex = 0;

        // Console.WriteLine();
        while (DateTime.Now < endTime)
            {
                Console.Write(spinner[spinnerIndex]);
                Thread.Sleep(250); // Spinner update interval
                Console.Write("\b"); // Backspace to overwrite spinner character
                spinnerIndex = (spinnerIndex + 1) % spinner.Length;
            }
        // Clear the last spinner character
        Console.Write(" ");
        Console.Write("\b");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b"); // Backspace to overwrite number character
        }
    }


}