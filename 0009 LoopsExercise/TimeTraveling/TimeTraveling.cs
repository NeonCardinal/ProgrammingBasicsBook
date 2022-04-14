using System;

public class TimeTraveling
{
    static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        double spendedMoneyPerYear = 0.0;
        int ivanAge = 18;

        for(int i = 1800; i <= year; i++)
        {
            if(i % 2 == 0)
            {
                spendedMoneyPerYear += 12000;
            }
            else
            {
                spendedMoneyPerYear += (12000 + 50 * ivanAge);
            }

            ivanAge++;
        }

        if(spendedMoneyPerYear <= money)
        {
            Console.WriteLine($"Yes! He will live a carefree life and will have {(money - spendedMoneyPerYear):F2} dollars left.");
        }
        else
        {
            Console.WriteLine($"He will need {(spendedMoneyPerYear - money):F2} dollars to survive");
        }
    }
}