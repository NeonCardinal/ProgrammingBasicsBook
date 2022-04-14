//Task 004, Chapter 4.1
using System;

public class MatchTickets
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string category = Console.ReadLine().ToLower();
        int people = int.Parse(Console.ReadLine());

        double transportPrice = 0.0;
        double ticketPrice = 0.0;
        string result = "";

        if (people >= 1 && people <= 4)
        {
            transportPrice = budget * 0.75;
        }
        else if (people >= 5 && people <= 9)
        {
            transportPrice = budget * 0.60;
        }
        else if (people >= 10 && people <= 24)
        {
            transportPrice = budget * 0.50;
        }
        else if (people >= 25 && people <= 49)
        {
            transportPrice = budget * 0.40;
        }
        else if (people >= 50)
        {
            transportPrice = budget * 0.25;
        }

        if (category == "vip")
        {
            ticketPrice = people * 499.99;
        }
        else if (category == "normal")
        {
            ticketPrice = people * 249.99;
        }

        double moneyDiff = budget - transportPrice - ticketPrice;

        if (moneyDiff >= 0.0)
        {
            Console.WriteLine($"Yes! You have {moneyDiff:F2} leva left.");
        }
        else if (moneyDiff < 0.0)
        {
            Console.WriteLine($"Not enough money! You need {Math.Abs(moneyDiff):F2} leva.");
        }
    }
}