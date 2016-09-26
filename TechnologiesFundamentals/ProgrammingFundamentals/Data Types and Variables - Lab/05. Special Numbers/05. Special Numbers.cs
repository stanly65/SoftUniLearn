using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());


        for (int num = 1; num <= n; num++)
        {
            int sumDigits = 0;
            int digits = num;

            while (digits > 0)
            {
                sumDigits = sumDigits + digits % 10;
                digits = digits / 10;
            }

            bool special = (sumDigits == 5 || sumDigits == 7 || sumDigits == 11);
            Console.WriteLine("{0} -> {1}", num, special);

        }
    }
}


