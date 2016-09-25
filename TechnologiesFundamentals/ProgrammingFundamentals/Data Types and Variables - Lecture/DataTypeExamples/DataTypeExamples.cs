using System;

class Program
{
    static void Main()
    {
        byte counter = 0; // [0...255]
        for (int i = 0; i < 260; i++)
        {
            counter++;
            Console.WriteLine(counter);
        
        }
    }
}

