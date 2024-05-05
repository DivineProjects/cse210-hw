using System;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display(){
        _date = DateTime.Now.ToString();
        // instantiate instance of Object of prompt Generator and assign string to promptText
        PromptGenerator promptGenerator= new PromptGenerator();
        _promptText = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"{_promptText}");





    }
}