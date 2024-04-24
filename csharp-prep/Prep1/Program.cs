using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("\nWhat is your first name? ");
        string fName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lName = Console.ReadLine();

        Console.WriteLine($"\nYour name is {fName}, {lName} {fName}.");
    }
}