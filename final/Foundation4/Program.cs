using System;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running(new DateTime(2024, 1, 23), 60, 3.0),
            new Cycling(new DateTime(2024, 2, 4), 130, 11.0),
            new Swimming(new DateTime(2024, 2, 12), 30, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
