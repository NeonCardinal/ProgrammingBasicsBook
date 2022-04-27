using System;

public class SumsThreeNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if(a + b == c)
        {
            if(a > b)
            {
                Console.WriteLine($"{b} + {a} = {c}");
            }
            else
            {
                Console.WriteLine($"{a} + {b} = {c}");
            }          
        }
        else if(a + c == b)
        {
            if(a > c)
            {
                Console.WriteLine($"{c} + {a} = {b}");
            }
            else
            {
                Console.WriteLine($"{a} + {c} = {b}");
            }
        }
        else if(b + c == a)
        {
            if(c > b)
            {
                Console.WriteLine($"{c} + {b} = {a}");
            }
            else
            {
                Console.WriteLine($"{b} + {c} = {a}");
            }           
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
