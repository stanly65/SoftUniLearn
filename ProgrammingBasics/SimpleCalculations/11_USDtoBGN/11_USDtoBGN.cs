using System;

class Program
{
    static void Main()
    {
        decimal usd = decimal.Parse(Console.ReadLine());

        var bgn = usd * 1.79549m;

        Console.WriteLine(Math.Round(bgn, 2));
    }
}
}

