using System;

public class Program
{

    public static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        string inputXD = Convert.ToString(input, 16);
        string inputBinary = Convert.ToString(input, 2);
        Console.WriteLine(inputXD.ToUpper());
        Console.WriteLine(inputBinary.ToUpper());
    }
}


