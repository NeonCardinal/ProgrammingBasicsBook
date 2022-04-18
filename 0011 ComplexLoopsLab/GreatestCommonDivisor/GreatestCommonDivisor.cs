using System;

public class GreatestCommonDivisor
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        while(b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        Console.WriteLine(a);
    }
}