using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        double courses = Math.Ceiling((double)n / p);
        Console.WriteLine((int)courses);
    }
}

