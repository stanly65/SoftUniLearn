using System;

class Program
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        int oddSumNumbers = 0;
        int evenSumNumbers = 0;
        for (int i = 1; i <= numbers; i++)
        {
            int tempNumber = int.Parse(Console.ReadLine());

            if ( i % 2 == 0)
            {
                evenSumNumbers = evenSumNumbers + tempNumber;
            }
            else if ( i % 2 != 0)
            {
                oddSumNumbers = oddSumNumbers + tempNumber;
            }
        }

        if (oddSumNumbers == evenSumNumbers)
        {
            Console.WriteLine("Yes Sum = {0}", oddSumNumbers);
        }
        else
        {
            Console.WriteLine("No Diff = {0}", Math.Abs(oddSumNumbers - evenSumNumbers));
        }
    }
}

