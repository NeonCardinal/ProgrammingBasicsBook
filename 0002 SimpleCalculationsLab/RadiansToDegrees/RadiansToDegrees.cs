using System;

public class RadiansToDegrees
{
    static void Main()
    {
        double rad;
        double deg;

        rad = double.Parse(Console.ReadLine());

        deg = rad * 180 / Math.PI;

        Console.WriteLine((int)(Math.Round(deg, 2)));
    }
}