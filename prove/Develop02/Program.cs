using System;
using System.Xml.Serialization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program");

        int choice = 0;
        string input;
        Journal journal = new Journal();
        // Entry entry1 = new Entry();
        do
        {
            Console.WriteLine("\nPlease select one of the following choices \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            Console.WriteLine("What would you like to do?");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Entry entry = new Entry();
                entry.Display();
                journal.AddEntry(entry);
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
            }

        } while (choice != 5);







    }
}