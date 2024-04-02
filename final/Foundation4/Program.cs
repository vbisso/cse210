using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\u001b[1m" + "FOUNDATION 4:\n");
        Console.Write("\u001b[0m");
        List<Activity> activityList = new List<Activity>();

        Running running = new Running("Running", "03 Apr 2024", 40.0, 5.0);
        Cycling cycling = new Cycling("Cycling", "05 Apr 2024", 25.0,5.0);
        Swimming swimming = new Swimming("Swimming", "09 Apr 2024", 90.0, 20);
        activityList.Add(running);  
        activityList.Add(cycling);
        activityList.Add(swimming);
        foreach (Activity activity in activityList)
        {
            activity.GetSummary();
        }


    }
}