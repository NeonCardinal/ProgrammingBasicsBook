﻿using System;

public class ExcellentOrNot
{
    static void Main()
    {
        double grade;

        grade = double.Parse(Console.ReadLine());

        if (grade >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
        else
        {
            Console.WriteLine("Not excellent.");
        }
    }
}