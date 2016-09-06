using System;

class Program
{
    static void Main()
    {
        int time1 = int.Parse(Console.ReadLine());
        int time2 = int.Parse(Console.ReadLine());
        int time3 = int.Parse(Console.ReadLine());
        int timeSum = time1 + time2 + time3;
        //  D / d   Целочислен формат, указваш минималното количество цифри
        Console.WriteLine("{0}:{1:D2}",timeSum /60,timeSum%60);
    }
}

