using System;

public class SleepyTomCat
{
    static void Main()
    {
        int days;

        days = int.Parse(Console.ReadLine());

        int workingDays = 365 - days;
        int totalPlayMinutes = workingDays * 63 + days * 127;
        int diff = Math.Abs(totalPlayMinutes - 30000);
        int hours = diff / 60;
        int minutes = diff % 60;

        if (totalPlayMinutes > 30000)
        {
            Console.WriteLine("Tom will run away");
            Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
        }
        else
        {
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
        }
    }
}