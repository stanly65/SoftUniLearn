using System;

public class Printing_Triangle
{

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintTriangle(n);
      
    }

    static void PrintLine(int start, int end) // печата линия от числа
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    static void PrintTriangle(int n) //печата се число до номера на реда в триъгълника! от 1...5- 5 ред
    {
        for (int row = 1; row <= n; row++)
        {
            PrintLine(1, row);
        }
        for (int row = n-1; row >= 1; row--)
        {
            PrintLine(1, row);
        }
    }

}


