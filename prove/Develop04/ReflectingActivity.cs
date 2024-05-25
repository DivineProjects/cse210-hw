using System;
using System.Collections.Generic;
using System.Threading; 


public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
        
    public ReflectingActivity(string name, string description) : base(name, description)
    {
        ReadWriteFiles readQuestions = new ReadWriteFiles("questions.txt");
        _questions = readQuestions.ReadFromFile();

        ReadWriteFiles readPrompts = new ReadWriteFiles("prompts.txt");
        _prompts = readPrompts.ReadFromFile();

    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        SetDuration();
        Console.WriteLine("Consider the following Prompt: ");
        DisplayPrompt();
        Thread.Sleep(5000);
        Console.Write($"Now ponder on each of the following questions as related to this experience. ");
        ShowCountDown(5); // Countdown to give user to start
        Console.Clear();
        DisplayQuestions(); 
        DisplayEndingMessage();
    }

    

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(0, _questions.Count);
        return _questions[index];
    }


    private void DisplayQuestions()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.Write($"{question} ");
            ShowSpinner(4);
            Console.WriteLine();
        }
    }

    private void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\t---- {prompt} ----");
    }
}