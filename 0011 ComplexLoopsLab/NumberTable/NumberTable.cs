﻿using System;

public class NumberTable
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                int num = i + j + 1;

                if(num > n)
                {
                    num = 2 * n - num;
                }

                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
    }
}