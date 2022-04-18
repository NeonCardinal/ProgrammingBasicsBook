using System;

public class Fibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int fZero = 1;
        int fOne = 1;

        for(int i = 0; i < n - 1; i++)
        {
            int fNext = fZero + fOne;
            fZero = fOne;
            fOne = fNext;
        }

        Console.WriteLine(fOne);
    }
}