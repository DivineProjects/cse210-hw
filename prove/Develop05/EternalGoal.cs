using System;

public class EternalGoal:Goal 
{
    public EternalGoal(string name, string description, int points): base(name, description, points)
    {

    }
   public override void RecordEvent()
   {
        _points = 70;
   } 
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal;{_shortName};{_description};{_points}";
    } 
    
    public override string GetDetailsString()
    {
        return $"[ ] {_shortName}: {_description} ({_points} points)";
    }
}