using System;

class Program
{
    static void Main()
    {
        {
            int n = int.Parse(Console.ReadLine());
            int result = 1;

            for (int i = 0; i <= n; i++)
            {
                //var result = Math.Pow(2, i); // степенуване (основа, показател)

                Console.WriteLine(result);
                result *= 2;
            }
        }
    }
}

