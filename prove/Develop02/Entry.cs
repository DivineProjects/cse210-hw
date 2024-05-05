using System;
using System.Collections.Generic;

public class Entry
{
    public string _date = DateTime.Now.ToString();
    public string _promptText;
    public string _entryText;
    // instantiate instance of Object of prompt Generator and assign string to promptText
    public PromptGenerator promptGenerator = new PromptGenerator();
    
    public Entry()
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd");
        _promptText = promptGenerator.GetRandomPrompt();
    }
    public void Display()
    {
        Console.WriteLine($"{_promptText}");
        _entryText = Console.ReadLine();
        //journal.AddEntry(entry1);
    }
}