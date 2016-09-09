using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            Console.WriteLine("*");

            return;
        }
        if (n == 2)
        {
            Console.WriteLine("**");

            return;
        }
        int stars = 1;
        int innerDashes = 1;
        if (n % 2 == 0)
        {
            stars = 2; // за четно n имаме **, за нечетно си остава *
            innerDashes = 2;
        }

        int outerDashes = (n - stars) / 2;

        // отпечатваме еднаквите top и botom
        Console.WriteLine("{0}{1}{0}", new string('-', outerDashes), new string('*', stars));
        outerDashes--;
        for (int i = 0; i < (n - 1) / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', outerDashes), new string('-', innerDashes));
            innerDashes += 2;
            outerDashes--;
        }
        innerDashes -= 4;
        outerDashes += 2;

        for (int i = 0; i < (n - 1) / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', outerDashes), new string('-', innerDashes));
            innerDashes -= 2;
            outerDashes++;
        }

        Console.WriteLine("{0}{1}{0}", new string('-', outerDashes), new string('*', stars));
    }
}

