using System;

class Program
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        int tempNumber = int.Parse(Console.ReadLine());
        int minNumber = tempNumber;

        for (int i = 1; i < numbers; i++)
        {
            tempNumber = int.Parse(Console.ReadLine());
            if (tempNumber < minNumber)
            {
                minNumber = tempNumber;
            }
        }
        Console.WriteLine(minNumber);
    }
}

