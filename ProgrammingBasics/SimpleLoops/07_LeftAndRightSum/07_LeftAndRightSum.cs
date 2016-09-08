using System;

class Program
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        int leftSumNumbers = 0;
        int rightSumNumbers = 0;
        for (int i = 1; i <= 2 * numbers; i++)
        {
            int tempNumber = int.Parse(Console.ReadLine());

            if (i <= numbers)
            {
                leftSumNumbers = leftSumNumbers + tempNumber;
            }
            else if (i > numbers)
            {
                rightSumNumbers = rightSumNumbers + tempNumber;
            }
        }

        if (leftSumNumbers == rightSumNumbers)
        {
            Console.WriteLine("Yes, sum = {0}", leftSumNumbers);
        }
        else
        {
            Console.WriteLine("No, diff = {0}", Math.Abs(leftSumNumbers - rightSumNumbers));
        }
    }
}

