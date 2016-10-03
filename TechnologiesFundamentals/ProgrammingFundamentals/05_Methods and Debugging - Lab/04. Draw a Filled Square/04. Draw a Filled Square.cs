using System;

public class Program
{

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintEndRow(n);
        for (int row = 2; row < n; row++) //Първият и последният (n) ред
        {                                  //печатаме с PrintEndRow(n);
            PrintMiddleRow(n);           
        }
        PrintEndRow(n);
    }
    static void PrintEndRow(int n)
    {
        Console.WriteLine(new string('-',2*n));
    }
    static void PrintMiddleRow(int n)
    {
        Console.Write('-');
        for (int col = 1; col < n; col++)
        {
            Console.Write("\\/");
        }
        Console.WriteLine('-');
    }
}


