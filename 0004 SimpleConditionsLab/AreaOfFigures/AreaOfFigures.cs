using System;

public class AreaOfFigures
{
    static void Main()
    {
        double a;
        double b;
        double area = 0.0;
        string figure = Console.ReadLine().ToLower();

        if (figure == "square")
        {
            a = double.Parse(Console.ReadLine());
            area = a * a;
        }
        else if (figure == "rectangle")
        {
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            area = a * b;
        }
        else if (figure == "circle")
        {
            a = double.Parse(Console.ReadLine());
            area = Math.PI * (a * a);
        }
        else if (figure == "triangle")
        {
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            area = a * b / 2;
        }

        Console.WriteLine(Math.Round(area, 3));
    }
}
