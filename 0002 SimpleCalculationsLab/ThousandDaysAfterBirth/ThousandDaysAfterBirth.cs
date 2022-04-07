using System;
using System.Globalization;

public class ThousandDaysAfterBirth
{
    static void Main()
    {
        string date = Console.ReadLine();
        DateTime dt = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        dt = dt.AddDays(1000);
        Console.WriteLine(dt.ToString("dd-MM-yyyy"));
    }
}