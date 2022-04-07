using System;

public class InchesToCentimeters
{
    static void Main()
    {
        double inches;
        double centimeters;

        Console.WriteLine("Inches = ");
        inches = double.Parse(Console.ReadLine());
        centimeters = inches * 2.54;
        Console.WriteLine("Centimeters = {0}", centimeters);
    }
}