using System;

class Program
{
    static void Main()
    {
        string productName = Console.ReadLine().ToLower();
        string dayWeek = Console.ReadLine().ToLower();
        decimal quantity = decimal.Parse(Console.ReadLine());

        if (dayWeek =="monday" || dayWeek == "tuesday" || dayWeek == "wednesday"
            || dayWeek == "thursday" || dayWeek == "friday")
        {
            switch (productName)
            {
                case "banana":
                    Console.WriteLine("{0:F2}",quantity*2.50m);
                    break;
                case "apple":
                    Console.WriteLine("{0:F2}", quantity * 1.20m);
                    break;

                case "orange":
                    Console.WriteLine("{0:F2}", quantity * 0.85m);
                    break;

                case "grapefruit":
                    Console.WriteLine("{0:F2}", quantity * 1.45m);
                    break;

                case "kiwi":
                    Console.WriteLine("{0:F2}", quantity * 2.70m);
                    break;

                case "pineapple":
                    Console.WriteLine("{0:F2}", quantity * 5.50m);
                    break;
                case "grapes":
                    Console.WriteLine("{0:F2}", quantity * 3.85m);
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
        else if (dayWeek == "saturday" || dayWeek == "sunday")
        {
            switch (productName)
            {
                case "banana":
                    Console.WriteLine("{0:F2}", quantity * 2.70m);
                    break;
                case "apple":
                    Console.WriteLine("{0:F2}", quantity * 1.25m);
                    break;

                case "orange":
                    Console.WriteLine("{0:F2}", quantity * 0.90m);
                    break;

                case "grapefruit":
                    Console.WriteLine("{0:F2}", quantity * 1.60m);
                    break;

                case "kiwi":
                    Console.WriteLine("{0:F2}", quantity * 3.00m);
                    break;

                case "pineapple":
                    Console.WriteLine("{0:F2}", quantity * 5.60m);
                    break;
                case "grapes":
                    Console.WriteLine("{0:F2}", quantity * 4.20m);
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}

