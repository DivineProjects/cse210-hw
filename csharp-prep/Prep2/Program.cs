using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        string sign= "";

        Console.Write("\nWhat is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        
        if (grade % 10 >=7)
        {
            if (!(grade >= 90 || grade < 60))
            {
                sign = "+";
            }
        }
        else if (grade % 10 <=3 && grade > 60)
        {
            sign = "-";
        }
        
        if (grade >= 90)
        {
            letter = "A";
        } else if (grade >= 80)
        {
            letter = "B";
        } else if (grade >= 70)
        { 
            letter = "C";
        } else if (grade >= 60)
        {
            letter = "D";
        } else if(grade < 60)
        {
            letter = "F";
        }
        
    
        Console.WriteLine($"Grade : {sign}{letter}");
        if (grade >= 70)
        {
            Console.WriteLine("Congradulation, You passed!!\n");
        } else
        {
            Console.WriteLine("Fail. Please Try Again\n");
        }

    }
}