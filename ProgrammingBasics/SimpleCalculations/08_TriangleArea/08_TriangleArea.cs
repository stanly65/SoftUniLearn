using System;

class Program
{
    static void Main()
    {
        double siteTriangle = double.Parse(Console.ReadLine());
        double heightTriangle = double.Parse(Console.ReadLine());
        double areaTriangle = (siteTriangle * heightTriangle) / 2.0;

        Console.WriteLine(Math.Round(areaTriangle, 2));
    }
}

