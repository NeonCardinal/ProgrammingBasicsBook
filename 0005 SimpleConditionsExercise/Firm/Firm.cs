//Task 005, Chapter 3.1
using System;

public class Firm
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        double workDays = days * 0.90;
        double overtime = workers * 2 * workDays;
        double workHours = Math.Floor(workDays * 8 + overtime);

        if (hours <= workHours)
        {
            Console.WriteLine($"Not enough time!{workHours - hours} hours needed.");
        }
        else
        {
            Console.WriteLine($"Yes!{hours - workHours} hours left.");
        }
    }
}