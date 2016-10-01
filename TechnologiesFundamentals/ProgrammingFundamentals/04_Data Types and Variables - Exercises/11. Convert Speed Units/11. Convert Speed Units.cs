using System;

public class Program
{

    public static void Main()
    {
        int distance_m = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int seconds = int.Parse(Console.ReadLine());

        int time_s = hours * 3600 + minutes * 60 + seconds;
        float ms = distance_m/(float) time_s;
        float kmh = (ms * 18)/5.0f;
        float mph = (distance_m / 1609f) / (time_s / 3600f);
        Console.WriteLine(ms);
        Console.WriteLine(kmh);
        Console.WriteLine(mph);

    }
}


