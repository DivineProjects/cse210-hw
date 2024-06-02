using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private List<Achievement> _achievements;
    private int _level;
    private int _pointsToNextLevel;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        // _goals = new List<Goal>();
        _achievements = new List<Achievement>();
        // _score = 0;
        _level = 1;
        _pointsToNextLevel = 300; // Example 

        InitializeAchievements();
    }

    public void Start()
    {
        Console.Clear();
        // Check achievements
        CheckAchievements();
        while (true)
        {
            CheckAchievements();
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Display Current Score");
            Console.WriteLine("2. Lists the Names of Each Goal.");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. List Achievements");
            Console.WriteLine("9. Exit");

            Console.Write("Choose an option: ");
            string input = Console.ReadLine();
            int choice = int.Parse(input);
            
            switch (choice)
            {
                case 1:
                    DisplayPlayerInfo();
                    break;
                case 2:
                    ListGoalNames();
                    break;
                case 3:
                    ListGoalDetails();
                    break;
                case 4:
                    CreateGoal();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    SaveGoals();
                    break;
                case 7:
                    LoadGoals();
                    break;
                case 8:
                    ListAchievements();
                    break;
                case 9:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score: {_score}");
        Console.WriteLine($"Player's current level: {_level}");
    }

    private void ListGoalNames()
    {

        if (_goals.Count > 0)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Goals List:");
            Console.WriteLine("------------------------------------------");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
            }
        }
        else
        {
            Console.WriteLine("No Goals List. Set New Goals");
        }
    }

    private void ListGoalDetails()
    {

        if (_goals.Count > 0)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Goal Details:");
            Console.WriteLine("------------------------------------------");
            foreach (Goal goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }
        else
        {
            Console.WriteLine("No Goal Details are available");
        }
    }

    private void CreateGoal()
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
                break;
            case "checklist":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());

                newGoal = new CheckListGoal(shortName, description, points, target, bonus);
                break;
            case "eternal":
                newGoal = new EternalGoal(shortName, description, points);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal created successfully.");
    }

    private void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Enter the number of the goal you have completed: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];
            goal.RecordEvent();

            _score += _goals[index].GetPoints();
            Console.WriteLine("\t*Event recorded successfully.");

            // /////////////
            // int pointsEarned = goal.GetPoints();
            // _score += pointsEarned;
            // Console.WriteLine($"Event recorded successfully. Points earned: {pointsEarned}");

            // Check for leveling up
            if (_score >= _pointsToNextLevel)
            {
                _level++;
                _score -= _pointsToNextLevel;
                _pointsToNextLevel += 300; // Increase threshold for next level
                Console.WriteLine($"Congratulations! You've leveled up to level {_level}!");
            }
            // Additional points for ChecklistGoal completion
            // _goals[index].IsComplete();
            if (goal is CheckListGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal.GetPoints();
                Console.WriteLine($"Bonus points earned: {checklistGoal.GetPoints()}");
            }

            // Check for achievements
            CheckAchievements();
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }

    }

    private void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    
    }

    private void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                _score = int.Parse(reader.ReadLine());
                _goals.Clear();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    Goal goal = null;

                    switch (parts[0])
                    {
                        case "SimpleGoal":
                            goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                            ((SimpleGoal)goal).SetCompletionStatus(bool.Parse(parts[4]));
                            break;
                        case "ChecklistGoal":
                            goal = new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]));
                            ((CheckListGoal)goal).SetAmountCompleted(int.Parse(parts[4]));
                            break;
                        case "EternalGoal":
                            goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                            break;
                    }

                    if (goal != null)
                    {
                        _goals.Add(goal);
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }

    ////// EXTRA ACHIEVEMENT 
    private void InitializeAchievements()
    {
        _achievements.Add(new Achievement("First Goal", "Complete your first goal"));
        _achievements.Add(new Achievement("Goal Master", "Complete 5 goals"));
        _achievements.Add(new Achievement("Point Collector", "Earn 500 points"));
    }

    private void ListAchievements()
    {
        Console.WriteLine("\nAchievements:");
        foreach (var achievement in _achievements)
        {
            Console.WriteLine(achievement);
        }
    }

    private void CheckAchievements()
    {
        foreach (var achievement in _achievements)
        {
            if (!achievement.GetIsUnlocked())
            {
                switch (achievement.GetName())
                {
                    case "First Goal":
                        if (_goals.Count > 0)
                            achievement.Unlock();
                        break;
                    case "Goal Master":
                        if (_goals.Count >= 10)
                            achievement.Unlock();
                        break;
                    case "Point Collector":
                        if (_score >= 500)
                            achievement.Unlock();
                        break;
                }
            }
        }


    }



}
