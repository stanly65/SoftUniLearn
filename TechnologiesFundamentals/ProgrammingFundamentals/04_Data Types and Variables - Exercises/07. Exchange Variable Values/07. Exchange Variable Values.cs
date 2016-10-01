using System;

public class Program
{

    public static void Main()
    {
        int a = 5;
        int b = 10;
        int temp_a = a;
        Console.WriteLine("Before:\r\n"+"a = 5\r\n"+"b = 10");
        a = b;
        b = temp_a;
        Console.WriteLine("After:\r\n" + "a = 10\r\n" + "b = 5");

    }
}


