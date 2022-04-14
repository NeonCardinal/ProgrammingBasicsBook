//Task 003, Chapter 4.1
using System;

public class Operations
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        string opt = Console.ReadLine();

        string output = "";
        double result = 0.0;

        if (secondNumber == 0 && (opt == "/" || opt == "%"))
        {
            output = $"Cannot divide {firstNumber} by zero";
        }
        else if (opt == "/")
        {
            result = firstNumber / secondNumber;
            output = $"{firstNumber} / {secondNumber} = {result:F2}";
        }
        else if (opt == "%")
        {
            result = firstNumber % secondNumber;
            output = $"{firstNumber} % {secondNumber} = {result}";
        }
        else
        {
            if (opt == "+")
            {
                result = firstNumber + secondNumber;
                output = $"{firstNumber} + {secondNumber} = {result} - {(result % 2 == 0 ? "even" : "odd")}";
            }
            else if (opt == "-")
            {
                result = firstNumber - secondNumber;
                output = $"{firstNumber} - {secondNumber} = {result} - {(result % 2 == 0 ? "even" : "odd")}";
            }
            else if (opt == "*")
            {
                result = firstNumber * secondNumber;
                output = $"{firstNumber} * {secondNumber} = {result} - {(result % 2 == 0 ? "even" : "odd")}";
            }
        }

        Console.WriteLine(output);
    }
}