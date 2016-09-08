using System;

class Program
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        int tempNumber1 = int.Parse(Console.ReadLine());
        int tempNumber2 = int.Parse(Console.ReadLine());
        int sumCouple = tempNumber1 + tempNumber2;
        int diff = 0;

        for (int i = 1; i < numbers; i++)
        {
            tempNumber1 = int.Parse(Console.ReadLine());
            tempNumber2 = int.Parse(Console.ReadLine());
            int sumTempCouple = tempNumber1 + tempNumber2;

            int diffTemp = Math.Abs(sumCouple - sumTempCouple);
            if (diffTemp > diff)
            {
                diff = diffTemp;
            }
            sumCouple = sumTempCouple;
        }

        if (diff == 0)
        {
            Console.WriteLine("Yes, value={0}", sumCouple);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", diff);
        }
    }
}
