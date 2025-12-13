using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(3.25, "Running", "31 Dec 2025", 23));
        activities.Add(new Cycling(11.0, "05 Mar 2026", "Cycling", 45));
        activities.Add(new Swimming(5, "Swimming", "01 Jan 2026", 15));
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}