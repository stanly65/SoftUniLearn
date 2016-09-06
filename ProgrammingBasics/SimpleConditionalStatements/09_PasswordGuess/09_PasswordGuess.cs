using System;

class Program
{
    static void Main()
    {
        string inputPassword = Console.ReadLine();
        string password = "s3cr3t!P@ssw0rd";
        if (inputPassword == password)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}

