using System;
using System.Collections.Generic;
using System.IO;

public class ReadScripture
{
    // declare attributes / member variable
    private string filename = "data.csv";
    private List<string> _verseList = new List<string>();
    private string _bookName;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private string _text;

    //Constructor
    public ReadScripture()
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            foreach (string part in parts)
            {
                _verseList.Add(part);
            }
        }

        // store values in member methods
        _bookName = _verseList[0];
        _chapter = Int32.Parse(_verseList[1]);
        _verse = Int32.Parse(_verseList[2]);
        _endVerse = Int32.Parse(_verseList[3]);
        _text = _verseList[4];
    }

    public string GetBook(){
        return _bookName;
    }

    public int GetChapter(){
        return _chapter;
    }

    public int GetVerse(){
        return _verse;
    }
    public int GetEndVerse(){
        return _endVerse;
    }

    public string GetText()
    {
        return _text;
    }
}