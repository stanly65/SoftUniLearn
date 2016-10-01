using System;

public class Program
{

    public static void Main()
    {
        string input = Console.ReadLine();
        bool isTrue = Convert.ToBoolean(input);
        if (isTrue == true) Console.WriteLine("Yes");
        else Console.WriteLine("No");
    }
}


