using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("+ {0}+", new String('-', n - 2).Replace("-", "- "));
        for (int i = 1; i <= n - 2; i++)
        {
            Console.WriteLine("| {0}|", new String('-', n - 2).Replace("-", "- "));
        }
        Console.WriteLine("+ {0}+", new String('-', n - 2).Replace("-", "- "));
    }        
}

