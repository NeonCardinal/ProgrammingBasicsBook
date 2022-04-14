using System;

public class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int evenSum = 0;
        int oddSum = 0;

        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if(i % 2 == 0)
            {
                evenSum += number;
            }
            else
            {
                oddSum += number;
            }
        }

        if(evenSum == oddSum)
        {
            Console.WriteLine($"Yes, sum = {evenSum}");
        }
        else
        {
            Console.WriteLine($"No, diff = {Math.Abs(evenSum - oddSum)}");
        }
    }
}