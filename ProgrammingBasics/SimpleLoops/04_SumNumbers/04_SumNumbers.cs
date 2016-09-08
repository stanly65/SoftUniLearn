using System;

class Program
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        int sumNumbers = 0;
        for (int i = 1; i <= numbers; i++)
        {
            int tempNumber = int.Parse(Console.ReadLine());
            sumNumbers = sumNumbers + tempNumber;
        }
        Console.WriteLine(sumNumbers);
    }
}

