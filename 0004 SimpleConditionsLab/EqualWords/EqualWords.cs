using System;

public class EqualWords
{
    static void Main()
    {
        string firstWord;
        string secondWord;

        firstWord = Console.ReadLine().ToLower();
        secondWord = Console.ReadLine().ToLower();

        if (firstWord == secondWord)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
