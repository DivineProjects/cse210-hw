using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a SimpleGoal instance
        SimpleGoal simpleGoal = new SimpleGoal("Drink Water", "Drink 8 cups of water in a day", 0);
        Console.WriteLine(simpleGoal.GetDetailsString());
        simpleGoal.RecordEvent();
        Console.WriteLine(simpleGoal.GetDetailsString());
        Console.WriteLine(simpleGoal.IsComplete());
        Console.WriteLine(simpleGoal.GetStringRepresentation());

        Console.WriteLine("\n\n\n");
        // Create an EternalGoal instance
        EternalGoal eternalGoal = new EternalGoal("Read Book", "Read a chapter of a book", 5);
        Console.WriteLine(eternalGoal.GetDetailsString());
        for (int i = 0; i < 3; i++)
        {
            eternalGoal.RecordEvent();
            Console.WriteLine(eternalGoal.GetDetailsString());
        }
        Console.WriteLine(eternalGoal.IsComplete());
        Console.WriteLine(eternalGoal.GetStringRepresentation());
    }
}