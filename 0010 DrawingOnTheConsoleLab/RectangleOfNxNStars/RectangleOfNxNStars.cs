using System;

public class RectangleOfNxNStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('*', n));
        }
    }
}