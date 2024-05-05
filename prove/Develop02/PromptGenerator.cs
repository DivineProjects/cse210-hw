using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // declare attributes
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {

        _prompts.AddRange(new string[] {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "Reflecting on today, who left the most lasting impression on you and why?",
            "Can you pinpoint a specific moment that brought you the most joy today?",
            "In what unexpected way did you feel guided or blessed today?",
            "Describe a moment today when your emotions were particularly intense.",
            "If you could change one decision or action from today, what would it be and why?",
            "Who provided the most valuable insight or perspective for you today?",
            "What event or encounter today made you feel the most grateful?",
            "Did you encounter any challenges today that tested your patience or resilience?",
            "Looking back on today, what is one lesson you learned about yourself?",
            "Was there a conversation or interaction today that you found particularly meaningful or thought-provoking?"
        });
        Random randInt = new Random();
        return _prompts[randInt.Next(0, _prompts.Count)];// number between 0 and length of list.
    }

}