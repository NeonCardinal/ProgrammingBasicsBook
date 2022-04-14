using System;

public class LeftRightSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int leftSum = 0;
        int rightSum = 0;

        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            leftSum += number;
        }

        for(int i = 0; i < n; i++)
        {
            rightSum += int.Parse(Console.ReadLine());
        }

        if(leftSum == rightSum)
        {
            Console.WriteLine($"Yes, sum = {leftSum}");
        }
        else
        {
            Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
        }
    }
}