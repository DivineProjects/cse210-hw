using System;

class Program
{
    static void Main(string[] args)
    {
        // // Create a SimpleGoal instance
        // SimpleGoal simpleGoal = new SimpleGoal("Drink Water", "Drink 8 cups of water in a day", 0);
        // Console.WriteLine(simpleGoal.GetDetailsString());
        // simpleGoal.RecordEvent();
        // Console.WriteLine(simpleGoal.GetDetailsString());
        // Console.WriteLine(simpleGoal.IsComplete());
        // Console.WriteLine(simpleGoal.GetStringRepresentation());

        // Console.WriteLine("\n\n\n");
        // // Create an EternalGoal instance
        // EternalGoal eternalGoal = new EternalGoal("Read Book", "Read a chapter of a book", 5);
        // Console.WriteLine(eternalGoal.GetDetailsString());
        // for (int i = 0; i < 3; i++)
        // {
        //     eternalGoal.RecordEvent();
        //     Console.WriteLine(eternalGoal.GetDetailsString());
        // }
        // Console.WriteLine(eternalGoal.IsComplete());
        // Console.WriteLine(eternalGoal.GetStringRepresentation());


        // // Create a ChecklistGoal instance
        // Console.WriteLine("\n\n\n");
        // CheckListGoal checklistGoal = new CheckListGoal("Exercise", "Exercise 5 times a week", 20, 5, 50);
        // Console.WriteLine(checklistGoal.GetDetailsString());
        // for (int i = 0; i < 5; i++)
        // {
        //     checklistGoal.RecordEvent();
        //     Console.WriteLine(checklistGoal.GetDetailsString());
        // }
        // Console.WriteLine(checklistGoal.IsComplete());
        // Console.WriteLine(checklistGoal.GetStringRepresentation());
        // run

        // GoalManager goalManager = new GoalManager();
        // 
    //     Manager manager= new Manager();
    //     // manager.DisplayPlayerInfo();
    //     // manager.ListGoalNames();
    //     // manager.ListGoalDetails();
    //     Console.Clear();
    //     while (true)
    //     {
            
    //         Console.WriteLine("\nMenu:");
    //         Console.WriteLine("1. Display Current Score");
    //         Console.WriteLine("2. Lists the Names of Each Goal.");
    //         Console.WriteLine("3. List Goal Details");
    //         Console.WriteLine("4. Create Goal");
    //         // Console.WriteLine("5. Record Event");
    //         // Console.WriteLine("6. Save Goals");
    //         // Console.WriteLine("7. Load Goals");
    //         Console.WriteLine("8. Exit");

    //         Console.Write("Choose an option: ");
    //         // string input = Console.ReadLine();
    //         int choice;
    //         string input = Console.ReadLine();

    //         // checks if inoute is an integer
    //         if (!(int.TryParse(input, out choice)))
    //         {
    //             choice = 0;
    //         }
            

    //         switch (choice)
    //         {
    //             case 1:
    //                 Console.WriteLine(choice);
    //                 manager.DisplayPlayerInfo();
    //                 break;
    //             case 2:
    //                 manager.ListGoalNames();
    //                 break;
    //             case 3:
    //                 manager.ListGoalDetails();
    //                 break;
    //             case 4:
    //                 manager.CreateGoal();
    //                 break;
    //             case 8:
    //                 return;
    //             default:
    //                 Console.WriteLine("Invalid option. Please try again.");
    //                 break;
    //         }
    //     }

    // Create a GoalManager instance
        GoalManager goalManager = new GoalManager();
        
        // Run the Start method to initiate the menu
        goalManager.Start();
    }
    
}