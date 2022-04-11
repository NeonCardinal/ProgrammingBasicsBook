//Task 011, Chapter 4.0
using System;

public class Cinema
{
    static void Main()
    {
        string type = Console.ReadLine().ToLower();
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        double income = 0.0;

        switch (type)
        {
            case "premiere":
                {
                    income = rows * cols * 12.00;
                }
                break;
            case "normal":
                {
                    income = rows * cols * 7.50;
                }
                break;
            case "discount":
                {
                    income = rows * cols * 5.00;
                }
                break;
        }

        Console.WriteLine($"{income:F2}");
    }
}