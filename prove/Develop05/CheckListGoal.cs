using System;

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            return _points + _bonus;
        }
        return _points; 
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal;{_shortName};{_description};{_points};{_amountCompleted};{_target};{_bonus}";
    }

    public override string GetDetailsString()
    {
        string checkbox;
        if (IsComplete())
        {
            checkbox = "[x]";
        }
        else
        {
            checkbox = "[ ]";
        }
        return $"{checkbox} {_shortName}: {_description} ({_points} points, {_amountCompleted}/{_target} completed)";
    }

    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }
}
