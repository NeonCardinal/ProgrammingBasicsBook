using System;

public class TimePlusFifteenMinutes
{
    static void Main()
    {
        int hours;
        int minutes;

        hours = int.Parse(Console.ReadLine());
        minutes = int.Parse(Console.ReadLine());

        if (minutes + 15 >= 60)
        {
            hours++;
            minutes = minutes + 15 - 60;
        }
        else
        {
            minutes += 15;
        }
        if (hours >= 24)
        {
            hours -= 24;
        }

        Console.WriteLine("{0:D1}:{1:D2}", hours, minutes);
    }
}
