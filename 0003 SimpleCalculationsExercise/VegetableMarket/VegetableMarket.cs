using System;

public class VegetableMarket
{
    static void Main()
    {
        int vegetableWeight;
        int fruidWeight;
        double vegetablePrice;
        double fruidPrice;
        double total;

        vegetablePrice = double.Parse(Console.ReadLine());
        fruidPrice = double.Parse(Console.ReadLine());
        vegetableWeight = int.Parse(Console.ReadLine());
        fruidWeight = int.Parse(Console.ReadLine());

        total = (vegetableWeight * vegetablePrice + fruidWeight * fruidPrice) / 1.94;

        Console.WriteLine(total);
    }
}