using System;

class Program
{
    static void Main()
    {
        //Напишете програма, която въвежда цяло положително число n
        //и печата на конзолата правоъгълник от n * n звездички. 
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write("*");

            }
            Console.WriteLine();
        }
    }
}

