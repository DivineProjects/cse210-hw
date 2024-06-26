using System;
using System.Collections.Generic;

public class ReadWriteFiles
{

    private string _filename;
    List<string> _fileLines = new List<string>();


    public ReadWriteFiles(string filename)
    {
        _filename = filename;
    }
    
    
    public List<string> ReadFromFile()
    {
        
        try
        {
            // Read all lines from the file into a string array
            string[] lines = File.ReadAllLines(_filename);
            _fileLines = lines.ToList();
           
        }
        catch (Exception ex)
        {
            // Handle any exceptions that occur during the file read operation
            Console.WriteLine("\n An error occurred while loading a file ");
        }
    
        return _fileLines;
    }


    public void WriteToFile( List<string> list)
    {
        try
        {
            // Save the List<string> to the file
            File.WriteAllLines(_filename, list);
            Console.WriteLine("\nList has been saved to " + _filename);
        }
        catch (Exception ex)
        {
            // Handle any exceptions that occur during the file write operation
            Console.WriteLine("An error occurred while saving the file: ");
        }
    }

    

}