using System;
using System.Threading;

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
        Console.WriteLine($"{_name}: {_description} ({_duration} seconds)");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"{_name}: {_description} ({_duration} seconds)");
    }

    public void showSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("."); // Replace it with the - character
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }


}