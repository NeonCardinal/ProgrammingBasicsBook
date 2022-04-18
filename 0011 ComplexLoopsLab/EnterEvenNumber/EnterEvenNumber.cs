using System;

public class EnterEvenNumber
{
    static void Main()
    {
        int n = 0;

        while(true)
        {
            Console.Write("Enter even number: ");

            n = int.Parse(Console.ReadLine());

            if(n % 2 == 0)
            {
                break;
            }
        }

        Console.WriteLine($"Even number entered: {n}");
    }
}