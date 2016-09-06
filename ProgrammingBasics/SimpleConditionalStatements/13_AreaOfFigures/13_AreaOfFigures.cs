using System;

class Program
{
    static void Main()
    {
        string geometricShape = Console.ReadLine();

        switch (geometricShape)
        {
            case "square":
                double sideSquare = double.Parse(Console.ReadLine());
                double areaSquare = Math.Pow(sideSquare, 2);
                Console.WriteLine(areaSquare);
                break;
            case "rectangle":
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double areaRectangle = sideA * sideB;
                Console.WriteLine(areaRectangle);
                break;
            case "circle":
                double radiusCircle = double.Parse(Console.ReadLine());
                double areaCircle = Math.PI * Math.Pow(radiusCircle, 2);
                Console.WriteLine(areaCircle);
                break;
            case "triangle":
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double areaTriangle = (side * height) / 2;
                Console.WriteLine(areaTriangle);
                break;
        }

    }
}

