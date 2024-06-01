using System;
using System.Collections.Generic;
using System.IO;

class Manager
{
    private List<Goal> _goals;
    private int _score;

    public Manager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

     public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score: {_score}");
    }

    
    public void ListGoalNames()
    {
        
        if (_goals.Count > 0){
            Console.WriteLine("Goals List:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
            }
        } else{
            Console.WriteLine("No Goals List. Set New Goals");
        }
    }

    public void ListGoalDetails()
    {
        if (_goals.Count > 0){
            Console.WriteLine("Goal Details:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        }else
        {
            Console.WriteLine("No Goal Details are available");
        }
    }

     public void CreateGoal()
    {
        Console.Write("Enter goal type (Simple, Checklist, Eternal): ");
        string type = Console.ReadLine().ToLower();

        Console.Write("Enter short name: ");
        string shortName = Console.ReadLine();

        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (type)
        {
            case "simple":
                newGoal = new SimpleGoal(shortName, description, points);
                Console.WriteLine(newGoal);
                break;
            case "checklist":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());

                newGoal = new CheckListGoal(shortName, description, points, target, bonus);
                Console.WriteLine(newGoal);
                break;
            case "eternal":
                newGoal = new EternalGoal(shortName, description, points);
                Console.WriteLine(newGoal);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                Console.WriteLine(newGoal);
                return;
        }

        _goals.Add(newGoal);
        Console.WriteLine(_goals);
        Console.WriteLine("Goal created successfully.");
    }



}