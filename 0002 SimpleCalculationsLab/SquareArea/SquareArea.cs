using System;

public class SquareArea
{
    static void Main()
    {
        int a;
        int area;

        Console.WriteLine("a = ");
        a = int.Parse(Console.ReadLine());
        area = a * a;
        Console.WriteLine("Square area = {0}", area);
    }
}
