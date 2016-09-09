using System;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var sum = 0;
        do
        {

            sum = sum + (n % 10);
            n = n / 10; // маха последната цифра на числото
        } while (n > 0);

        Console.WriteLine("Sum of digits: {0}", sum);
    }
}

