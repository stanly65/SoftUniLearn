using System;

class Program
{
    private static object 葉;

    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine()); // ? \
        Console.WriteLine($"Hello, {firstName} {lastName}.\nYou are {age} years old."); 

    }
}

