using System;
using System.Xml.Serialization;
using System.Collections.Generic;

class Program
{
    /* Creativity and Exceeding Requirements
        --------------------------------------
        1. Included additional prompt questions
        2. Create a History file and class that captures the per entry Responses
        3. History class saves and loads as a .csv file 
     */
    static void Main(string[] args)
    {
        Console.WriteLine("\n=========================================================");
        Console.WriteLine("Welcome to the Journal Program");
        Console.WriteLine("\n=========================================================");

        int choice = 0;
        string input;
        Journal journal = new Journal();
        History history = new History();
        do
        {
            Console.WriteLine("\nPlease select one of the following choices \n1. Write \n2. Display \n3. Load \n4. Save \n 5. Read Daily Entries \n6. Quit");
            Console.WriteLine("What would you like to do?");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Entry entry = new Entry();
                entry.Display();
                journal.AddEntry(entry);
                history.AddEntry(entry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                // prompt user for file name
                Console.Write("What is the file name: ");
                input = Console.ReadLine();
                journal.LoadFromFile(input);
            }
            else if (choice == 4)
            {
                // prompt user for file name
                Console.Write("What is the file name: ");
                input = Console.ReadLine();
                journal.SaveToFile(input);
                // Write data to CSV
                history.WriteToHistory();
            }
            else if (choice == 5)
            {
                history.Display();
            }

        } while (choice != 6);

    }
}