using System;

public class GreaterNumber
{
    static void Main()
    {
        int firstNumber;
        int secondNumber;

        firstNumber = int.Parse(Console.ReadLine());
        secondNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            Console.WriteLine(firstNumber);
        }
        else
        {
            Console.WriteLine(secondNumber);
        }
    }
}