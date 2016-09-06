using System;

class Program
{
    static void Main()
    {
        int hour = int.Parse(Console.ReadLine());
        int minute = int.Parse(Console.ReadLine());
        int timeMinute = hour * 60 + minute;
        int timeMinutePlus15 = timeMinute + 15;
        if (timeMinutePlus15>=1440)
        {
            timeMinutePlus15 = timeMinutePlus15 - 1440;
        }
        Console.WriteLine("{0}:{1:d2}",timeMinutePlus15/60,timeMinutePlus15%60);
    }
}

