//Task 004, Chapter 4.0
using System;

public class FruitOrVegetable
{
    static void Main()
    {
        string str = Console.ReadLine().ToLower();

        if (str == "banana" || str == "apple" || str == "kiwi" || str == "cherry" ||
            str == "lemon" || str == "grapes")
        {
            Console.WriteLine("fruit");
        }
        else if (str == "tomato" || str == "cucumber" || str == "pepper" || str == "carrot")
        {
            Console.WriteLine("vegetable");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}