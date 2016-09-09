using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                count = count + 1;
                Console.Write(count + " ");
                if (count == n) return;
            }
            Console.WriteLine();
        }
    }
}


