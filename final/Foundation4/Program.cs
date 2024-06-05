using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 06, 2), 20, 2.0),
            new Cycling(new DateTime(2024, 06, 3), 30, 8.0),
            new Swimming(new DateTime(2024, 06, 4), 45, 15)
        };

        Console.Clear();
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}