using System;

public class CheckPrime
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if(n < 2)
        {
            Console.WriteLine("Not prime");
            return;
        }

        bool isPrime = true;

        for(int i = 2; i <= Math.Sqrt(n); i++)
        {
            if(n % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if(isPrime)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("Not prime");
        }
    }
}