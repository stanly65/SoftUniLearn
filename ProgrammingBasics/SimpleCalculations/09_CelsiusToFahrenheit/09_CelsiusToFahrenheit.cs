using System;

class Program
{
    static void Main()
    {
        double degreesCentigrade = double.Parse(Console.ReadLine());
        double degreeFahrenheit = degreesCentigrade * 9 / 5 + 32;

        Console.WriteLine(Math.Round(degreeFahrenheit, 2));
    }
}

