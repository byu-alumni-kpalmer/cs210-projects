using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 02, 19), 30, 3.0),
            new Running(new DateTime(2024, 02, 19), 30, 4.8),
            new Cycling(new DateTime(2024, 02, 19), 45, 15),
            new Swimming(new DateTime(2024, 02, 19), 60, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
