using System;

class DailyEarnings
{
    static void Main()
    {
        int workDays = int.Parse(Console.ReadLine());
        double dailySalary = double.Parse(Console.ReadLine());
        double correctCurency = double.Parse(Console.ReadLine());

        double monthSalary = workDays * dailySalary;
        double yearSalary = monthSalary * 12 + monthSalary * 2.5;
        double vat = yearSalary * 0.25;
        double neto = (yearSalary - vat) * correctCurency;
        double result = neto / 365;

        Console.WriteLine(Math.Round(result, 2));
    }
}
