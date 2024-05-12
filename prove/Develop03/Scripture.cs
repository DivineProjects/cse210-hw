using System;
using System.Collections.Generic;

public class Scripture
{
    //member variables
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    public int _numberToHide;

    // constructor
    public Scripture(Reference reference, string text)
    {
        _reference =reference;
        // convert text to array
        string[] textArray = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string wordText in textArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    // methods

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<int> numbers = new List<int>();

        // Checks if the numberToHide does not exceed the total number of words
        numberToHide = Math.Min(numberToHide, _words.Count);

        for (int i = 0; i < numberToHide; i++)
        {
            int r = random.Next(0, _words.Count()); //generates random numbers in the range [min, max]
            _words[r].Hide(); // hides word and Replaces itwith ---
        }

        foreach (var word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
    }

    public string GetDisplayText()
    {
        string displayText = ""; 
        _reference.GetDsiplayText();
        foreach (var word in _words)
        {
            word.Show();
            displayText += word.GetDisplayText();
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        if (_words.Count >= _numberToHide)
        {
            return true;
        }else
        {
            return false;
        }
    }


}