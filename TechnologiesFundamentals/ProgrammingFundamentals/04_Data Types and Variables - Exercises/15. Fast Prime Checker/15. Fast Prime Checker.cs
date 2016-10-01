using System;

public class Program
{

    public static void Main()
    {
        int numberFinal = int.Parse(Console.ReadLine());
        for (int counter = 2; counter <= numberFinal; counter++)
        {
            bool isTrue = true;
            for (int divisor = 2; divisor <= Math.Sqrt(counter); divisor++)
            {
                if (counter % divisor == 0)
                {
                    isTrue = false;
                    break;
                }
            }
            Console.WriteLine($"{counter} -> {isTrue}");
        }

    }
}


