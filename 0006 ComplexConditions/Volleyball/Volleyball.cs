//Task 012, Chapter 4.0
using System;

public class Volleyball
{
    static void Main()
    {
        string year = Console.ReadLine().ToLower();
        int holidays = int.Parse(Console.ReadLine());
        int weekendsHome = int.Parse(Console.ReadLine());

        double sofiaWeekends = (48 - weekendsHome) * (3.0 / 4.0);
        double playSofia = holidays * (2.0 / 3.0);
        double playTotal = sofiaWeekends + playSofia + weekendsHome;

        if (year == "leap")
        {
            playTotal += playTotal * 0.15;
        }

        Console.WriteLine(Math.Floor(playTotal));
    }
}