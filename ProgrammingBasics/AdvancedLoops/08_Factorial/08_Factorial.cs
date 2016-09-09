using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int fact = 1;
        do
        {
            fact *= n;
            n--;
        } while (n > 1);

        Console.WriteLine(fact);
    }
}

