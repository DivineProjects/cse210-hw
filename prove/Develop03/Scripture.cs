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
        _reference = reference;
        // convert text to array
        string[] textArray = text.Split(new char[] { ' ', '\n', '\r','\t' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string wordText in textArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    // methods

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        _numberToHide = numberToHide;
        List<int> numbers = new List<int>();
        List<int> indexes = Enumerable.Range(0, _words.Count).ToList(); // Create a list of indexes
        
        // numberToHide should not exceed the total number of words
        numberToHide = Math.Min(numberToHide, _words.Count);

        for (int i = 0; i < numberToHide; i++)
        {
            int randIndex = random.Next(0, indexes.Count);// generates random numbers in the range [min, max]
            int wordIndex = indexes[randIndex]; // get index in the _words list
            _words[wordIndex].Hide(); // Hide the word
            indexes.RemoveAt(randIndex); // Remove the index from the list to avoid repetition
        }
        _reference.GetDsiplayText();
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
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        if (_words.Count > _numberToHide)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}