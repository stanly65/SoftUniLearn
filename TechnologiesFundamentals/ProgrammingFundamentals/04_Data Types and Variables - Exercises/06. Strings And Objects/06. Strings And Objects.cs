using System;

public class Program
{

    public static void Main()
    {
        string input1 = "Hello";
        string input2 = "World";
        object concatenation = string.Concat(input1, " ", input2);
        Console.WriteLine((string)concatenation);
    }
}


