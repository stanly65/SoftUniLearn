using System;

public class Program
{

    public static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double heightA = double.Parse(Console.ReadLine());
        double triangleArea = GetTriangleArea(sideA, heightA);
        Console.WriteLine(triangleArea);
    }

    static double GetTriangleArea(double width, double height)
    {
        return width * height / 2;
    }
}


