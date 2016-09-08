using System;

class Program
{
    static void Main()
    {
        string product = Console.ReadLine().ToLower();
        string town = Console.ReadLine().ToLower();
        decimal quantity = decimal.Parse(Console.ReadLine());
        if (town == "sofia")
        {
            switch (product)
            {
                case "coffee":
                    Console.WriteLine(quantity*0.50m);
                    break;
                case "water":
                    Console.WriteLine(quantity * 0.80m);
                    break;
                case "beer":
                    Console.WriteLine(quantity * 1.20m);
                    break;
                case "sweets":
                    Console.WriteLine(quantity * 1.45m);
                    break;
                case "peanuts":
                    Console.WriteLine(quantity * 1.60m);
                    break;
            }
        }
        if (town == "varna")
        {
            switch (product)
            {
                case "coffee":
                    Console.WriteLine(quantity * 0.45m);
                    break;
                case "water":
                    Console.WriteLine(quantity * 0.70m);
                    break;
                case "beer":
                    Console.WriteLine(quantity * 1.10m);
                    break;
                case "sweets":
                    Console.WriteLine(quantity * 1.35m);
                    break;
                case "peanuts":
                    Console.WriteLine(quantity * 1.55m);
                    break;
            }
        }
        if (town == "plovdiv")
        {
            switch (product)
            {
                case "coffee":
                    Console.WriteLine(quantity * 0.40m);
                    break;
                case "water":
                    Console.WriteLine(quantity * 0.70m);
                    break;
                case "beer":
                    Console.WriteLine(quantity * 1.15m);
                    break;
                case "sweets":
                    Console.WriteLine(quantity * 1.30m);
                    break;
                case "peanuts":
                    Console.WriteLine(quantity * 1.50m);
                    break;
            }
        }
    }
}

