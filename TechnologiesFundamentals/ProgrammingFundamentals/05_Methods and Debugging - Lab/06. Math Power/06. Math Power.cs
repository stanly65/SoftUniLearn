using System;

public class Program
{

    public static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());
        Console.WriteLine(RaiseToPower(number, power));
       
    }

    static double RaiseToPower(double number, int power)
    {
        double result = 1;
        if (power == 0) result = 1;
        else if (power > 0)
        {
            for (int i = 1; i <= power; i++)
            {
                result = number * result;
            }

        }
        else if (power <0) //отрицателна степен
        {
            for (int i = 1; i <= Math.Abs(power); i++)
            {
                result = number * result;
            }
            result = 1 / result;
        }
        return result;
    }
}


