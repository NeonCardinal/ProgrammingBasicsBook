using System;

public class TransportPrice
{
    static void Main()
    {
        int n;
        string time;
        double price;
        double taxiRate;

        price = 0.0;
        n = int.Parse(Console.ReadLine());
        time = Console.ReadLine().ToLower();

        if (time == "day")
        {
            taxiRate = 0.79;
        }
        else
        {
            taxiRate = 0.90;
        }

        if (n < 20)
        {
            price = taxiRate * n + 0.70;
        }
        else if (n < 100)
        {
            price = n * 0.09;
        }
        else
        {
            price = n * 0.06;
        }

        Console.WriteLine(price);
    }
}