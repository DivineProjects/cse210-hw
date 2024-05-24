using System;
using System.Threading;
using System.Threading.Tasks.Dataflow;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity)");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nThank You for participating in the {_name} Activity");
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        string[] spinner = { "/", "-", "|", "-" };
        int spinnerIndex = 0;

        Console.WriteLine();
        while (DateTime.Now < endTime)
            {
                Console.Write(spinner[spinnerIndex]);
                Thread.Sleep(250); // Spinner update interval
                Console.Write("\b"); // Backspace to overwrite spinner character
                spinnerIndex = (spinnerIndex + 1) % spinner.Length;
            }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > -1; i--)
        {
            Console.Write($"{i} ");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b\b"); // Backspace to overwrite number character
        }
    }


}