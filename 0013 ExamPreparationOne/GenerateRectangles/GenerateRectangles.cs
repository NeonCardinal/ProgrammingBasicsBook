﻿using System;

public class GenerateRectangles
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int cout = 0;
        //int area = 0;

        for(int left = -n; left < n; left++)
        {
            for (int top  = -n; top < n; top++)
            {
                for(int right = left + 1; right <= n; right++)
                {
                    for(int bottom = top + 1; bottom <= n; bottom++)
                    {
                        int area = Math.Abs(right - left) * Math.Abs(bottom - top);

                        if(area >= m)
                        {
                            Console.WriteLine($"({left}, {top}) ({right}, {bottom}) -> {area}");
                            cout++;
                        }
                    }
                }
            }
        }

        if(cout == 0)
        {
            Console.WriteLine("No");
        }
    }
}