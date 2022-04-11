//Task 001, Chapter 4.0
using System;

public class PersonalTitles
{
    static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        string gender = Console.ReadLine().ToLower();

        if (age < 16)
        {
            if (gender == "m")
            {
                Console.WriteLine("Master");
            }
            else if (gender == "f")
            {
                Console.WriteLine("Miss");
            }
        }
        else if (age >= 16)
        {
            if (gender == "m")
            {
                Console.WriteLine("Mr.");
            }
            else if (gender == "f")
            {
                Console.WriteLine("Ms.");
            }
        }
    }
}