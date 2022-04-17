using System;

public class RectangleOfTenxTenStars
{
    static void Main()
    {
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine(new string('*', 10));
        }
    }
}