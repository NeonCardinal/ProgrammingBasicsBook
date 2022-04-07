using System;

public class TwoDRectangleArea
{
    static void Main()
    {
        double x1;
        double x2;
        double y1;
        double y2;
        double width;
        double height;

        x1 = double.Parse(Console.ReadLine());
        y1 = double.Parse(Console.ReadLine());
        x2 = double.Parse(Console.ReadLine());
        y2 = double.Parse(Console.ReadLine());

        width = Math.Max(x1, x2) - Math.Min(x1, x2);
        height = Math.Max(y1, y2) - Math.Min(y1, y2);

        Console.WriteLine(width * height);
        Console.WriteLine((width + height) * 2);
    }
}