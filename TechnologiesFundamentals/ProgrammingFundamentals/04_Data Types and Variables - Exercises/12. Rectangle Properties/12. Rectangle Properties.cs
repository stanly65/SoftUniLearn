using System;

public class Program
{

    public static void Main()
    {
        double rectangleWidth = double.Parse(Console.ReadLine());
        double rectangleHeight = double.Parse(Console.ReadLine());

        double perimeter = (rectangleWidth + rectangleHeight) * 2;
        double area = rectangleWidth * rectangleHeight;
        double diagonal = Math.Sqrt(Math.Pow(rectangleHeight, 2) + Math.Pow(rectangleWidth, 2));
        Console.WriteLine(perimeter);
        Console.WriteLine(area);
        Console.WriteLine(diagonal);
    }
}


