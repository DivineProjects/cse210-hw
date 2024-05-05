using System;

public class PromptGenerator
{
    // declare attributes
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt(){
        _prompts = ["Who was the most interesting person I interacted with today?",
                    "What was the best part of my day?",
                    "How did I see the hand of the Lord in my life today?",
                    "What was the strongest emotion I felt today?",
                    "If I had one thing I could do over today, what would it be?"];

        Random randInt = new Random(); 
        return _prompts[randInt.Next(0, _prompts.Count)];// number between 0 and length of list.
    }

}