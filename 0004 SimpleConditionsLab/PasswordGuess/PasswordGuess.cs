using System;

public class PasswordGuess
{
    static void Main()
    {
        string password;

        password = Console.ReadLine();

        if (password == "s3cr3t!P@ssw0rd")
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}