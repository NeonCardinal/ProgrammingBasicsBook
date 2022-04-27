using System;

public class PointOnSegment
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int point = int.Parse(Console.ReadLine());

        int left = Math.Min(start, end);
        int right = Math.Max(start, end);
        int distanceLeft = Math.Abs(left - point);
        int distanceRight = Math.Abs(right - point);
        int minDistance = Math.Min(distanceLeft, distanceRight);

        if(point >= left && point <= right)
        {
            Console.WriteLine("in");
        }
        else
        {
            Console.WriteLine("out");
        }

        Console.WriteLine(minDistance);
    }
}