using System;

public class PointInFigure
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        bool firstFugure = x >= 2 && x <= 12 && y >= -3 && y <= 1;
        bool secondFigure = x >= 4 && x <= 10 && y >= -5 && y <= 3;

        if(firstFugure || secondFigure)
        {
            Console.WriteLine("in");
        }
        else
        {
            Console.WriteLine("out");
        }
    }
}