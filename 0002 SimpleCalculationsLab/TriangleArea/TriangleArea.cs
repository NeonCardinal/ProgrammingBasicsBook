using System;

class TriangleArea
{
    static void Main()
    {
        double a;
        double h;
        double area;

        a = double.Parse(Console.ReadLine());
        h = double.Parse(Console.ReadLine());

        area = a * h / 2;

        Console.WriteLine(Math.Round(area, 2));
    }
}