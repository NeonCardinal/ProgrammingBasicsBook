using System;

public class Bricks
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int w = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int bricks = w * m;
        double courses = Math.Ceiling((double)x / bricks);

        Console.WriteLine(courses);
    }
}