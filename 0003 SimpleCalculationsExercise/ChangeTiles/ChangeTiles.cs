using System;

class ChangeTiles
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double wTile = double.Parse(Console.ReadLine());
        double lTile = double.Parse(Console.ReadLine());
        int wBench = int.Parse(Console.ReadLine());
        int lBench = int.Parse(Console.ReadLine());

        double tileArea = wTile * lTile;
        double benchArea = wBench * lBench;
        double result = ((n * n) - benchArea) / tileArea;
        double time = result * 0.2;

        Console.WriteLine(result);
        Console.WriteLine(time);
    }
}
