using System;

public class Program
{
    public static void Main()
    {
        int sumPictures = int.Parse(Console.ReadLine());
        int filterTime = int.Parse(Console.ReadLine());
        int filterFactror = int.Parse(Console.ReadLine());
        int uploadTime = int.Parse(Console.ReadLine());

        long overallFilterTime = (long)sumPictures * filterTime;
        long filteredPictures = (long)Math.Ceiling((double)sumPictures * filterFactror / 100);
        long overallUploadTime = filteredPictures * uploadTime;
        long time = overallUploadTime + overallFilterTime;

        TimeSpan timeSpan = TimeSpan.FromSeconds((long)time);

        Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
            timeSpan.Days,
            timeSpan.Hours,
            timeSpan.Minutes,
            timeSpan.Seconds);

    }
}


