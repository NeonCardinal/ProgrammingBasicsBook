using System;

public class IncreasingElements
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int currentLongest = 0;
        int longest = 0;
        int a = 0;
        int aPrev = 0;

        for(int i = 0; i < n; i++)
        {
            a = int.Parse(Console.ReadLine());

            if(a > aPrev)
            {
                currentLongest++;
            }
            else
            {
                currentLongest = 1;
            }

            if(currentLongest > longest)
            {
                longest = currentLongest;
            }

            aPrev = a;
        }

        Console.WriteLine(longest);
    }
}