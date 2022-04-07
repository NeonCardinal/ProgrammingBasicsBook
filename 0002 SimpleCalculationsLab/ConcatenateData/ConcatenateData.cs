using System;

public class ConcatenateData
{
    static void Main()
    {
        int age;
        string firstName;
        string lastName;
        string town;

        firstName = Console.ReadLine();
        lastName = Console.ReadLine();
        age = int.Parse(Console.ReadLine());
        town = Console.ReadLine();

        Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", firstName, lastName, age, town);
    }
}