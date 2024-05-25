using System;
using System.Collections.Generic;
using System.Threading; 

public class ListingActivity : Activity
{
    private List<string> _promptsList = new List<string>();
    private int _count;
    
    public ListingActivity(string name, string description): base(name, description)
    {
        ReadWriteFiles readPrompts = new ReadWriteFiles("listngPromps.txt");
        _promptsList  = readPrompts.ReadFromFile();
        // _promptsList = new List<string>
        // {
        //     "Who are people that you appreciate?",
        //     "What are personal strengths of yours?",
        //     "Who are people that you have helped this week?",
        //     "When have you felt the Holy Ghost this month?",
        //     "Who are some of your personal heroes?"
        // };

        _count = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();
        SetDuration();

        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following Prompt: ");
        Console.WriteLine($"\t---- {prompt} ----");
        Console.Write($"You will start in ");
        ShowCountDown(5); // Countdown to give user time to think about the prompt
        Console.WriteLine();
        List<string> userInputsList = GetListFromUser();
        _count = userInputsList.Count;
        ShowSpinner(4);
        Console.WriteLine($"You listed {_count} items.");
        ShowSpinner(4);
        SaveListingResponses(userInputsList) ;
        DisplayEndingMessage();

    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _promptsList[random.Next(0, _promptsList.Count)];
    }

    private List<string> GetListFromUser()
    {
        List<string> userInputs = new List<string>();
        // string prompt = GetRandomPrompt();
        // Console.WriteLine("Consider the following Prompt: ");
        // Console.WriteLine($"\t---- {prompt} ----");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                userInputs.Add(input);
            }
        }

        return userInputs;
    }

    public void SaveListingResponses(List<string> list)
    {
        ReadWriteFiles writePrompts = new ReadWriteFiles("listingResponse.txt");
        writePrompts.WriteToFile(list);
    }



}