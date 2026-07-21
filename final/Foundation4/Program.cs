using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> acts = new List<Activity>();
        acts.Add(new Running("03 Nov 2022", 30, 4.8));
        acts.Add(new Cycling("01 Jan 2021", 60, 20.4));
        acts.Add(new Swimming("12 Feb 2026", 10, 3));

        foreach (Activity a in acts)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}