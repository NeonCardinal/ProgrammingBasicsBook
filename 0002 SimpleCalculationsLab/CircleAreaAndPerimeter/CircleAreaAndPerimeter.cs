using System;

public class CircleAreaAndPerimeter
{
    static void Main()
    {
        double r;
        double area;
        double perimeter;

        r = double.Parse(Console.ReadLine());

        area = Math.PI * r * r;
        perimeter = 2 * Math.PI * r;

        Console.WriteLine("Area = " + area);
        Console.WriteLine("Perimeter = " + perimeter);
    }
}