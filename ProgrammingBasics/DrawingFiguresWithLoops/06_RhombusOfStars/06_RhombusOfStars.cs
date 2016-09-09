using System;

class Program
{
    static void Main()
    {
        //Напишете програма, която въвежда цяло положително число n
        //и печата ромбче от звездички с размер n 
        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= n - row; col++)

            {
                Console.Write(" ");
            }
            Console.Write("*");

            for (int col = 1; col < row; col++)
            {
                Console.Write(" *");

            }
            Console.WriteLine();
        }

        for (int row = n - 1; row >= 1; row--) //обръщаме цикъла и минус 1 ред
        {
            for (int col = 1; col <= n - row; col++)

            {
                Console.Write(" ");
            }
            Console.Write("*");

            for (int col = 1; col < row; col++)
            {
                Console.Write(" *");

            }
            Console.WriteLine();
        }
    }
}

