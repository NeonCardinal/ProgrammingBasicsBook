//Task 004, Chapter 3.1
using System;

public class Harvest
{
    static void Main()
    {
        int area = int.Parse(Console.ReadLine());
        double grapes = double.Parse(Console.ReadLine());
        int neededLiters = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        double harvestPerVine = area * grapes * 0.40;
        double vine = harvestPerVine / 2.5;

        if (vine >= neededLiters)
        {
            double leftVine = vine - neededLiters;
            Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(vine)} liters.");
            Console.WriteLine($"{Math.Ceiling(leftVine)} liters left -> {Math.Ceiling(leftVine / workers)} liters per person.");
        }
        else
        {
            Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededLiters - vine)} liters wine needed.");
        }
    }
}