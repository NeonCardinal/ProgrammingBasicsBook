﻿using System;

public class PowersOfTwo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int number = 1;

        for(int i = 0; i <= n; i++)
        {
            Console.WriteLine(number);
            number *= 2;
        }
    }
}