using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference()
    {

    }

    // constuctors
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }


    // methods
    public void GetDsiplayText()
    {
        if (_endVerse != 0)
        {
            Console.WriteLine($"{_book} {_chapter}:{_verse}-{_endVerse}");
        }
        else if (_endVerse == _verse)
        {
            Console.WriteLine($"{_book} {_chapter} {_verse}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter} {_verse}");
        }
    }

}