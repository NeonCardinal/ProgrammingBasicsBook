using System;

public class SmartLily
{
    static void Main()
    {
        int lilysAge = int.Parse(Console.ReadLine());
        double washingMachinePrice = double.Parse(Console.ReadLine());
        double toyPrice = double.Parse(Console.ReadLine());
        int toyCounter = 0;
        int savings = 0;
        int moneyFromBD = 10;

        for(int i = 1; i <= lilysAge; i++)
        {
            if(i % 2 == 0)
            {
                savings += (moneyFromBD - 1);
                moneyFromBD += 10;
            }
            else
            {
                toyCounter++;
            }
        }

        double moneyFromToys = toyCounter * toyPrice;
        double money = savings + moneyFromToys;

        if(money >= washingMachinePrice)
        {
            Console.WriteLine($"Yes! {(money - washingMachinePrice):F2}");
        }
        else
        {
            Console.WriteLine($"No! {(washingMachinePrice - money):F2}");
        }
    }
}