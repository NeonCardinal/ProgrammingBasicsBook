using System;

class Money
{
    static void Main()
    {
        int bitcoins = int.Parse(Console.ReadLine());
        double uans = double.Parse(Console.ReadLine());
        double comission = double.Parse(Console.ReadLine());

        double bitcoinsInLeva = bitcoins * 1168;
        double uansInleva = uans * 0.15 * 1.76;
        double totalInEuro = (bitcoinsInLeva + uansInleva) / 1.95;
        double percentComission = comission / 100;
        double temp = totalInEuro * percentComission;
        double result = totalInEuro - temp;

        Console.WriteLine(result);
    }
}