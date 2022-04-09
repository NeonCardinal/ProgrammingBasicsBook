using System;

public class SumSeconds
{
    static void Main()
    {
        int firstNumber;
        int secondNumber;
        int thirdNumber;
        int seconds;
        int minutes;

        minutes = 0;
        firstNumber = int.Parse(Console.ReadLine());
        secondNumber = int.Parse(Console.ReadLine());
        thirdNumber = int.Parse(Console.ReadLine());
        seconds = firstNumber + secondNumber + thirdNumber;

        if (seconds > 59)
        {
            minutes++;
            seconds -= 60;
        }
        if (seconds > 59)
        {
            minutes++;
            seconds -= 60;
        }

        if (seconds < 10)
        {
            Console.WriteLine(minutes + ":" + "0" + seconds);
        }
        else
        {
            Console.WriteLine(minutes + ":" + seconds);
        }
    }
}
