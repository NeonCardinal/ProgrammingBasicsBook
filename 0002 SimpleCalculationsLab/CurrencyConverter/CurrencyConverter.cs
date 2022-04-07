using System;

public class CurrencyConverter
{
    static void Main()
    {
        double leva;
        double amount = double.Parse(Console.ReadLine());
        string currentCurrency = Console.ReadLine().ToLower();
        string wantedCurrency = Console.ReadLine().ToLower();

        if (currentCurrency == "bgn" && wantedCurrency == "gbp")
        {
            leva = amount / 2.53405;
            Console.WriteLine("{0:F2}", leva);
        }
        else if (currentCurrency == "bgn" && wantedCurrency == "eur")
        {
            leva = amount / 1.95583;
            Console.WriteLine("{0:F2}", leva);
        }
        else if (currentCurrency == "bgn" && wantedCurrency == "usd")
        {
            leva = amount / 1.79549;
            Console.WriteLine("{0:F2}", leva);
        }

        if (currentCurrency == "eur" && wantedCurrency == "bgn")
        {
            leva = amount = amount * 1.95583;
            Console.WriteLine("{0:F2}", leva);
        }
        else if (currentCurrency == "eur" && wantedCurrency == "gbp")
        {
            leva = amount * 1.95583 / 2.53405;
            Console.WriteLine("{0:F2}", leva);
        }
        else if (currentCurrency == "eur" && wantedCurrency == "usd")
        {
            leva = amount * 1.95583 / 1.79549;
            Console.WriteLine("{0:F2}", leva);
        }

        if (currentCurrency == "gbp" && wantedCurrency == "bgn")
        {
            leva = amount * 2.53405;
            Console.WriteLine("{0:F2}", leva);
        }
        else if (currentCurrency == "gbp" && wantedCurrency == "eur")
        {
            leva = amount * 2.53405 / 1.95583;
            Console.WriteLine("{0:F2}", leva);
        }
        else if (currentCurrency == "gbp" && wantedCurrency == "usd")
        {
            leva = amount * 2.53405 / 1.79549;
            Console.WriteLine("{0:F2}", leva);
        }

        if (currentCurrency == "usd" && wantedCurrency == "bgn")
        {
            leva = amount * 1.79549;
            Console.WriteLine("{0:F2}", leva);
        }
        else if (currentCurrency == "usd" && wantedCurrency == "eur")
        {
            leva = amount * 1.79549 / 1.95583;
            Console.WriteLine("{0:F2}", leva);
        }
        else if (currentCurrency == "usd" && wantedCurrency == "gbp")
        {
            leva = amount * 1.79549 / 2.52405;
            Console.WriteLine("{0:F2}", leva);
        }
    }
}