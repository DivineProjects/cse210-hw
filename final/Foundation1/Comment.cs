using System;

public class Comment
{
    private string _comment;
    private string _name;

    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetComment()
    {
        return _comment;
    }
}