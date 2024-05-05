using System;
using System.Collections.Generic;
using System.IO;

public class History
{
    public string filename = "data.csv";
    // declare attributes / member variable
    public List<Entry> _entries = new List<Entry>();
    public string _date = DateTime.Now.ToString();
    public string _text;

    // Methods
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void WriteToHistory()
    {
        try
        {

            foreach (Entry line in _entries)
            {
                _text += line._entryText + ",";
            };

            using (StreamWriter outputFile = new StreamWriter(filename, true))
            {

                outputFile.WriteLine($"Date: {_date},{_text}");
            };

        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    public void Display()
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }


}
