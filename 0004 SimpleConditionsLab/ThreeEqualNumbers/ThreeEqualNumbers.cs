using System;

public class ThreeEqualNumbers
{
    static void Main()
    {
        int firstNumber;
        int secondNumber;
        int thirdNumber;

        firstNumber = int.Parse(Console.ReadLine());
        secondNumber = int.Parse(Console.ReadLine());
        thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber == secondNumber && secondNumber == thirdNumber)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
