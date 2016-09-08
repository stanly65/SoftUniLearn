using System;

class Program
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        string point1 = "";
        
        int x1 = 0;
        int y1 = 0;
        int x2 = 3 * h;
        int y2 = h;

        int x3 = h;
        int y3 = h;
        int x4 = 2 * h;
        int y4 = 4 * h;

        if ((x > x1 && x < x2) & (y > y1 && y < y2))
        {
            point1 = "inside";
        }
        else if (y == y2 && (x > x3 && x < x4))
        {
            point1 = "inside";
        }
        else if ((x > x3 && x < x4) & (y > y3 && y < y4))
        {
            point1 = "inside";
        }

        else if ((x == x1 || x == x2) && (y >= y1 && y <= y2))
        {
            point1 = "border";
        }
        else if (((y == y1) && (x >= x1 && x <= x2)))
        {
            point1 = "border";
        }
        else if ((y == y2) && ((x >= x1 && x <= x3) || (x >= x4 && x <= x2)))
        {
            point1 = "border";
        }
        else if ((x == x3 || x== x4) && (y>=y3 && y <= y4))                 
        {
            point1 = "border";
        }
        else if (y==y4 && (x>=x3 && x<=x4))
        {
            point1 = "border";
        }

        else
        {
            point1 = "outside";
        }
        Console.WriteLine(point1);
    }
}
