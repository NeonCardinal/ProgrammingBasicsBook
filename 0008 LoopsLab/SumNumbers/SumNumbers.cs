using System;

public class SumNumbers
{
    static void Main()
    {
        int sum = 0;
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;
        }

        Console.WriteLine(sum);
    }
}