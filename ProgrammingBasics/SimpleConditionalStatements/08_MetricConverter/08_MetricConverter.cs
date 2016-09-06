using System;

class Program
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        string inputUnit = Console.ReadLine();
        string outputUnit = Console.ReadLine();

        double inputNumber_m = 0.0;
        double outputNumber = 0.0;

        switch (inputUnit)
        {
            case "mm":
                inputNumber_m = number / 1000;
                break;
            case "cm":
                inputNumber_m = number / 100;
                break;
            case "mi":
                inputNumber_m = number / 0.000621371192;
                break;
            case "in":
                inputNumber_m = number / 39.3700787;
                break;
            case "km":
                inputNumber_m = number / 0.001;
                break;
            case "ft":
                inputNumber_m = number / 3.2808399;
                break;
            case "yd":
                inputNumber_m = number / 1.0936133;
                break;
            case "m":
                inputNumber_m = number;
                break;
        }
        switch (outputUnit)
        {
            case "mm":
                outputNumber = inputNumber_m * 1000;
                break;
            case "cm":
                outputNumber = inputNumber_m * 100;
                break;
            case "mi":
                outputNumber = inputNumber_m * 0.000621371192;
                break;
            case "in":
                outputNumber = inputNumber_m * 39.3700787;
                break;
            case "km":
                outputNumber = inputNumber_m * 0.001;
                break;
            case "ft":
                outputNumber = inputNumber_m * 3.2808399;
                break;
            case "yd":
                outputNumber = inputNumber_m * 1.0936133;
                break;
            case "m":
                outputNumber = inputNumber_m ;
                break;
        }
        Console.WriteLine("{0} {1}",outputNumber, outputUnit);
    }
}

