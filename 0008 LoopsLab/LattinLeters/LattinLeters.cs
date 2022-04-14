using System;

public class LattinLeters
{
    static void Main()
    {
        for(char symbol = 'a'; symbol <= 'z'; symbol++)
        {
            Console.Write($"{symbol} ");
        }

        Console.WriteLine();
    }
}