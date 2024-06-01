using System;
public class Achievement 
{
    private string _name;
    private string _description;
    private bool _isUnlocked;

    public Achievement(string name, string description)
    {
        _name = name;
        _description = description;
        _isUnlocked = false;
    }

    public string GetName()
    {
        return _name;
    }

    public bool GetIsUnlocked()
    {
        return _isUnlocked;
    }

    public void Unlock()
    {
        if (!_isUnlocked)
        {
            _isUnlocked = true;
            Console.WriteLine($"Achievement Unlocked: {_name} - {_description}");
        }
    }

    public override string ToString()
    {
        return $"{_name}: {_description} - {(_isUnlocked ? "Unlocked" : "Locked")}";
    }

}