using System;

public class TrainingLab
{
    static void Main()
    {
        int rows;
        int cols;
        int result;
        double len;
        double widht;
        double lenInCm;
        double widthInCm;

        len = double.Parse(Console.ReadLine());
        widht = double.Parse(Console.ReadLine());

        lenInCm = len * 100;
        widthInCm = widht * 100 - 100;

        rows = (int)(lenInCm / 120);
        cols = (int)(widthInCm / 70);
        result = rows * cols - 3;

        Console.WriteLine(result);
    }
}
