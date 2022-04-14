using System;

public class Histogram
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int cntP1 = 0;
        int cntP2 = 0;
        int cntP3 = 0;
        int cntP4 = 0;
        int cntp5 = 0;
        double p1Percent = 0.0;
        double p2Percent = 0.0;
        double p3Percent = 0.0;
        double p4Percent = 0.0;
        double p5Percent = 0.0;

        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if(number < 200)
            {
                cntP1++;
            }
            else if(number >= 200 && number <= 399)
            {
                cntP2++;
            }
            else if(number >= 400 && number <= 599)
            {
                cntP3++;
            }
            else if(number >= 600 && number <= 799)
            {
                cntP4++;
            }
            else if(number >= 800)
            {
                cntp5++;
            }
        }

        p1Percent = cntP1 * 100.0 / n;
        p2Percent = cntP2 * 100.0 / n;
        p3Percent = cntP3 * 100.0 / n;
        p4Percent = cntP4 * 100.0 / n;
        p5Percent = cntp5 * 100.0 / n;

        Console.WriteLine($"{p1Percent:F2}%");
        Console.WriteLine($"{p2Percent:F2}%");
        Console.WriteLine($"{p3Percent:F2}%");
        Console.WriteLine($"{p4Percent:F2}%");
        Console.WriteLine($"{p5Percent:F2}%");
    }
}