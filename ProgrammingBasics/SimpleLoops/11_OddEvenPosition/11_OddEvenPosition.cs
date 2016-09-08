using System;

class Program
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        double SumNumbersOddPosition = 0;
        double SumNumbersEvenPosition = 0;
        double minNumberOddPosition = double.MaxValue;
        double maxNumberOddPosition = double.MinValue;
        double minNumberEvenPosition = double.MaxValue;
        double maxNumberEvenPosition = double.MinValue;




        for (int i = 1; i <= numbers; i++)
        {
            double tempNumber = double.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                SumNumbersEvenPosition = SumNumbersEvenPosition + tempNumber;
                minNumberEvenPosition = Math.Min(minNumberEvenPosition, tempNumber);
                maxNumberEvenPosition = Math.Max(maxNumberEvenPosition, tempNumber);

            }
            else if (i % 2 != 0)
            {
                SumNumbersOddPosition = SumNumbersOddPosition + tempNumber;
                minNumberOddPosition = Math.Min(minNumberOddPosition, tempNumber);
                maxNumberOddPosition = Math.Max(maxNumberOddPosition, tempNumber);

            }
        }

        Console.WriteLine("OddSum={0}", SumNumbersOddPosition);

            if (minNumberOddPosition != double.MaxValue)
                Console.WriteLine("OddMin={0}", minNumberOddPosition);
            else Console.WriteLine("OddMin=No");

            if (maxNumberOddPosition != double.MinValue)
                Console.WriteLine("OddMax={0}", maxNumberOddPosition);
            else Console.WriteLine("OddMax=No");

            Console.WriteLine("EvenSum={0}", SumNumbersEvenPosition);

            if (minNumberEvenPosition != double.MaxValue)
                Console.WriteLine("EvenMin={0}", minNumberEvenPosition);
            else Console.WriteLine("EvenMin=No");

            if (maxNumberEvenPosition != double.MinValue)
                Console.WriteLine("EvenMax={0}", maxNumberEvenPosition);
            else Console.WriteLine("EvenMax=No");

    }
}
