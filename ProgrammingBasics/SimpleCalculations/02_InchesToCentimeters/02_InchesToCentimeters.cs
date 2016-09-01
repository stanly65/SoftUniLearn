using System;

class Program
{
    static void Main()
    {
        var num = decimal.Parse(Console.ReadLine());
        var inch = 2.54m;

        var cm = num * inch;
        Console.WriteLine(cm);
    }
}

