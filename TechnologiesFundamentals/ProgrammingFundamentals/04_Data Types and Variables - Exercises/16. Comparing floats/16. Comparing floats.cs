using System;

public class Program
{

    public static void Main()
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());

        double difference = Math.Abs(num1 - num2);
        const double epsilon = 0.000001;

        if (difference < epsilon)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}


