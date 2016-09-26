using System;

class Program
{
    static void Main()
    {
        double volumeRegularPyramid = 0;
        double lengthBase = 0;
        double widthBase = 0;
        double heightPyramid = 0;

        Console.Write("Length: ");
        lengthBase = double.Parse(Console.ReadLine());
        Console.Write("Width: ");
        widthBase = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        heightPyramid = double.Parse(Console.ReadLine());

        volumeRegularPyramid = (lengthBase * widthBase) * heightPyramid / 3d;
        Console.WriteLine("Pyramid Volume: {0:F2}", volumeRegularPyramid);

    }
}

