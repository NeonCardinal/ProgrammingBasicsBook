using System;

public class MaxNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int greater = int.MinValue;

        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if(number > greater)
            {
                greater = number;
            }
        }

        Console.WriteLine(greater);
    }
}