using System;

class Program
{
    static void Main()
    {
        for (int row = 1; row <= 10; row++)
        {
            string asterisk = new string('*', row);
            Console.WriteLine(asterisk);
        }
    }
}

