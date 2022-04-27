using System;

public class SumsStepThree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sumOne = 0;
        int sumTwo = 0;
        int sumThree = 0;

        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if(i % 3 == 0)
            {
                sumOne += number;
            }
            if(i % 3 == 1)
            {
                sumTwo += number;
            }
            if(i % 3 == 2)
            {
                sumThree += number;
            }
        }

        Console.WriteLine($"Sum1 = {sumOne}");
        Console.WriteLine($"Sum2 = {sumTwo}");
        Console.WriteLine($"Sum3 = {sumThree}");
    }
}