using System;

public class USDToBGN
{
    static void Main()
    {
        double usd;
        double bgn;

        usd = double.Parse(Console.ReadLine());

        bgn = usd * 1.79549;

        Console.WriteLine(Math.Round(bgn, 2));
    }
}