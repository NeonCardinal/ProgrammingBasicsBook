using System;

public class PipesInPool
{
    static void Main()
    {
        int volume;
        int firstPipe;
        int secondPipe;
        double hours;
        double water;

        volume = int.Parse(Console.ReadLine());
        firstPipe = int.Parse(Console.ReadLine());
        secondPipe = int.Parse(Console.ReadLine());
        hours = double.Parse(Console.ReadLine());

        water = (firstPipe + secondPipe) * hours;

        if (water <= volume)
        {
            Console.WriteLine($"The pool is {Math.Truncate(water / volume * 100)}% full. " +
                $"Pipe 1: {Math.Truncate(firstPipe * hours / water * 100)}%. " +
                $"Pipe 2: {Math.Truncate(secondPipe * hours / water * 100)}%.");
        }
        else
        {
            Console.WriteLine($"For {hours} hours the pool overflows with {water - volume} liters.");
        }
    }
}