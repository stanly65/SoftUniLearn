using System;

class Program
{
    static void Main()
    {
        string kindYear = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int playVolleyballHometown = int.Parse(Console.ReadLine());
        double playVolleyballDays = 0.0;

        double playVolleyballWeekend = (48 - playVolleyballHometown) * 0.75;
        double playVolleyballHolidays = (holidays * 2) / 3.0;
        playVolleyballDays = playVolleyballHolidays + playVolleyballWeekend + playVolleyballHometown;
        if (kindYear == "leap")
        {
            playVolleyballDays = playVolleyballDays + playVolleyballDays * 0.15;
        }
        
        Console.WriteLine(Math.Truncate(playVolleyballDays));
    }
}

