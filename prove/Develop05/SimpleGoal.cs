using System;

public class SimpleGoal : Goal
{

    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points): base(shortName, description, points)
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

    public override int RecordEvent()
    {
        return _points;
    }

    public void SetCompletionStatus(bool status)
    {
        _isComplete = status;
    }
}