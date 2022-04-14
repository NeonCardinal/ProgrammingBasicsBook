//Task 002, Chapter 4.1
using System;

public class Trip
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string seazon = Console.ReadLine().ToLower();

        double spentMoney = 0.0;
        string result = string.Empty;
        string place = string.Empty;

        if (budget <= 100)
        {
            result = "Bulgaria";
            if (seazon == "summer")
            {
                place = "Camp";
                spentMoney = budget * 0.30;
            }
            else if (seazon == "winter")
            {
                place = "Hotel";
                spentMoney = budget * 0.70;
            }
        }
        else if (budget > 100 && budget <= 1000)
        {
            result = "Balkans";
            if (seazon == "summer")
            {
                place = "Camp";
                spentMoney = budget * 0.40;
            }
            else if (seazon == "winter")
            {
                place = "Hotel";
                spentMoney = budget * 0.80;
            }
        }
        else if (budget > 1000)
        {
            result = "Europe";
            place = "Hotel";
            spentMoney = budget * 0.90;
        }

        Console.WriteLine($"Somewhere in {result}");
        Console.WriteLine($"{place} - {spentMoney:F2}");
    }
}