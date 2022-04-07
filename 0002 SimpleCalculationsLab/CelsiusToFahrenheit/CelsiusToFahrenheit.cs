using System;

public class CelsiusToFahrenheit
{
    static void Main()
    {
        double celsius;
        double fahrenheit;

        celsius = double.Parse(Console.ReadLine());

        fahrenheit = celsius * 9 / 5 + 32;

        Console.WriteLine(Math.Round(fahrenheit, 2));
    }
}