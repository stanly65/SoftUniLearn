using System;

class Program
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        int tempNumber = int.Parse(Console.ReadLine());
        int maxNumber = tempNumber;

        for (int i = 1; i < numbers; i++)
        {
            tempNumber = int.Parse(Console.ReadLine());
            if (tempNumber > maxNumber)
            {
                maxNumber = tempNumber;
            }
        }
        Console.WriteLine(maxNumber);
    }
}

