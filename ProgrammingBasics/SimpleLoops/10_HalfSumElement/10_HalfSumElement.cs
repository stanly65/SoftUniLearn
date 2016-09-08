using System;

class Program
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        int tempNumber = int.Parse(Console.ReadLine());
        int maxNumber = tempNumber;
        int sumNumbers = tempNumber;

        for (int i = 1; i < numbers; i++)
        {
            tempNumber = int.Parse(Console.ReadLine());
            if (tempNumber > maxNumber)
            {
                maxNumber = tempNumber;
            }
            sumNumbers = sumNumbers + tempNumber;
        }
        if (maxNumber * 2 - sumNumbers == 0)
        {
            Console.WriteLine("Yes Sum = {0}", maxNumber);
        }
        else
        {
            Console.WriteLine("No Diff = {0}", Math.Abs(2 * maxNumber - sumNumbers));
        }
    }
}

