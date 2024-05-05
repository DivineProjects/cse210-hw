using System;
using System.IO;
using System.Collections.Generic;
public class Journal
{
    // declare attributes / member variable
    public List<Entry> _entries = new List<Entry>();

    // Methods
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry ent in _entries)
        {
            Console.WriteLine($"Date: {ent._date} - {ent._promptText} \n{ent._entryText}\n");
        };
    }

    public void SaveToFile(string filename)
    {
        try
        {
            // Create a StreamWriter instance to write to the file
            using (StreamWriter outputFile = new StreamWriter(filename, true))
            {
                // add text to the file with the WriteLine method
                foreach (Entry line in _entries)
                {
                    outputFile.WriteLine($"Date: {line._date} - {line._promptText} \n{line._entryText}\n");
                };
            };

            Console.WriteLine("File successfully saved.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    public void LoadFromFile(string filename)
    {
        string filePath = filename;
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}