using System;

class Program
{
    static void Main()
    {
        decimal inputValie = decimal.Parse(Console.ReadLine());
        string inputCurrency = Console.ReadLine();
        string outputCurrency = Console.ReadLine();

        decimal inputValieInBgn = 0;
        if (inputCurrency == "USD")
        {
            inputValieInBgn = inputValie * 1.79549m;
        }

        if (inputCurrency == "EUR")
        {
            inputValieInBgn = inputValie * 1.95583m;
        }

        if (inputCurrency == "GBP")
        {
            inputValieInBgn = inputValie * 2.53405m;
        }

        if (inputCurrency == "BGN")
        {
            inputValieInBgn = inputValie;
        }
        //---------------------------------------------------------------
        decimal outputValue = 0;

        if (outputCurrency == "USD")

        {
            outputValue = inputValieInBgn / 1.79549m;
            Console.WriteLine("{0:F2} {1}", outputValue, outputCurrency);
        }

        if (outputCurrency == "EUR")
        {

            outputValue = inputValieInBgn / 1.95583m;
            Console.WriteLine("{0:F2} {1}", outputValue, outputCurrency);
        }

        if (outputCurrency == "GBP")
        {
            outputValue = inputValieInBgn / 2.53405m;
            Console.WriteLine("{0:F2} {1}", outputValue, outputCurrency);
        }

        if (outputCurrency == "BGN")
        {
            outputValue = inputValieInBgn;
            Console.WriteLine("{0:F2} {1}", outputValue, outputCurrency);
        }

    }
}

