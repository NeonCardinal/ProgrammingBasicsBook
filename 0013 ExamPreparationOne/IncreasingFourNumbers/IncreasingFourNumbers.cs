using System;

public class IncreasingFourNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int count = 0;

        for(int i = a; i <= b; i++)
        {
            for(int j = i + 1; j <= b; j++)
            {
                for(int k = j + 1; k <= b; k++)
                {
                    for(int p = k + 1; p <= b; p++)
                    {
                        Console.WriteLine($"{i} {j} {k} {p}");
                        count++;
                    }
                }
            }
            //Console.WriteLine();
        }

        if(count == 0)
        {
            Console.WriteLine("No");
        }
    }
}
