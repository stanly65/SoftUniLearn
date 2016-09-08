using System;

class Program
{
    static void Main()
    {
        string typeProjection = Console.ReadLine();
        int row = int.Parse(Console.ReadLine());
        int column = int.Parse(Console.ReadLine());
        decimal result = 1.00m;
        if (typeProjection == "Premiere")
        {
            result = row * column * 12.00m; 
        }
        else if (typeProjection == "Normal")
        {
            result = row * column * 7.50m;
        }
        else if (typeProjection == "Discount")
        {
            result = row * column * 5.00m;
        }
        Console.WriteLine("{0:F2} leva",result);
    }
}

