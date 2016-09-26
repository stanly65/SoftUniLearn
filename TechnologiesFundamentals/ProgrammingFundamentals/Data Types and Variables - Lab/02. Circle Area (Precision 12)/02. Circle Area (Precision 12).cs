using System;

class Program
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F12}", Math.PI * r * r);
    }
}

