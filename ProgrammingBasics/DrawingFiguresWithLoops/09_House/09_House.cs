using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        // TODO top
        int stars = 1;
        int dashes = (n - stars) / 2; //зависимости спрямо n
        if (n % 2 == 0) // четно число 2 звезди
        {
            stars = 2;
        }
        for (int i = 0; i < (n + 1) / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', dashes), new string('*', stars));
            stars += 2;
            dashes--;
        }

        //TODO bottom
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("|{0}|", new string('*', n - 2));
        }

    }
}

