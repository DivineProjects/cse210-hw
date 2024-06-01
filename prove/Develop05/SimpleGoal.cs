using System;

public class SimpleGoal : Goal
{

    private bool _isComplete;

    public SimpleGoal(string name, string description, int points): base(name, description, points)
    {
        _isComplete = false;
    }

    public override string GetDetailsString()
    {
        string checkbox;
        if (_isComplete) 
        {
            checkbox = "[x]";
        } else{
            checkbox = "[ ]";
        }
        return $"{checkbox} {_shortName}: {_description} ({_points} points)";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal;{_shortName};{_description};{_points};{_isComplete}";
    }

    public override bool IsComplete()
    {
        return _isComplete = true;
    }

    public override void RecordEvent()
    {
        _points = 50;
    }
}