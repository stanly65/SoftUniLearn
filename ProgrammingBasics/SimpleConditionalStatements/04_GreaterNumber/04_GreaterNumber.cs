using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two integers:");
        int numberFirst = int.Parse(Console.ReadLine());
        int numberSecond = int.Parse(Console.ReadLine());
        Console.Write("Greater number: ");
        if (numberFirst > numberSecond)
        {
            Console.WriteLine(numberFirst);
        }
        else if (numberFirst == numberSecond)
        {
            Console.WriteLine(numberFirst);
        }
        else //(numberFirst < numberSecond)
        {
            Console.WriteLine(numberSecond);
        }
    }
}

