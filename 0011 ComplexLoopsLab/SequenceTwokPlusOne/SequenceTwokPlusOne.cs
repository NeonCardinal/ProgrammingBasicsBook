using System;

public class SequenceTwokPlusOne
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int number = 1;

        while(number <= n)
        {
            Console.WriteLine(number);

            number = 2 * number + 1;
        }
    }
}