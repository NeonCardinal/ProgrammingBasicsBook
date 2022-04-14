using System;

public class Divide
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double cntP1 = 0;
        double cntP2 = 0;
        double cntP3 = 0;
        int count = 0;
        double p1Percent = 0.0;
        double p2Percent = 0.0;
        double p3Percent = 0.0;

        for(int i = 1; i <= n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            count++;

            if(number % 2 == 0)
            {
                cntP1++;
            }
            if(number % 3 == 0)
            {
                cntP2++;
            }
            if(number % 4 == 0)
            {
                cntP3++;
            }
        }

        p1Percent = cntP1 / n * 100;
        p2Percent = cntP2 / n * 100;
        p3Percent = cntP3 / n * 100;

        Console.WriteLine($"{p1Percent:F2}%");
        Console.WriteLine($"{p2Percent:F2}%");
        Console.WriteLine($"{p3Percent:F2}%");
    }
}