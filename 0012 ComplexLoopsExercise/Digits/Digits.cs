using System;

public class Digits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int firstDigit = n / 100;
        int secondDigit = (n % 100) / 10;
        int thirdDigit = n % 10;
        int rows = firstDigit + secondDigit;
        int cols = firstDigit + thirdDigit;

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                if(n % 5 == 0)
                {
                    n -= firstDigit;
                }
                else if(n % 3 == 0)
                {
                    n -= secondDigit;
                }
                else
                {
                    n += thirdDigit;
                }

                Console.Write($"{n} ");
            }

            Console.WriteLine();
        }
    }
}