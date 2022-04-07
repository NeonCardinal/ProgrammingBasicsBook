using System;

public class TrapeziodArea
{
    static void Main()
    {
        double b1;
        double b2;
        double h;
        double area;

        b1 = double.Parse(Console.ReadLine());
        b2 = double.Parse(Console.ReadLine());
        h = double.Parse(Console.ReadLine());

        area = (b1 + b2) * h / 2;

        Console.WriteLine("Trapezion area = " + area);
    }
}