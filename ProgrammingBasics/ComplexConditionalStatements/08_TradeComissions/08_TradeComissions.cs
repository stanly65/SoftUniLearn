using System;

class Program
{
    static void Main()
    {
        string town = Console.ReadLine().ToLower();
        decimal sales = decimal.Parse(Console.ReadLine());
        decimal comission = 1;
        if (town == "sofia")
        {
            if (sales >= 0 && sales <= 500) comission = 0.05m;
            else if (sales > 500 && sales <= 1000) comission = 0.07m;
            else if (sales > 1000 && sales <= 10000) comission = 0.08m;
            else if (sales > 10000) comission = 0.12m;
            else goto label;
        }
        else if (town == "varna")
        {
            if (sales >= 0 && sales <= 500) comission = 0.045m;
            else if (sales > 500 && sales <= 1000) comission = 0.075m;
            else if (sales > 1000 && sales <= 10000) comission = 0.10m;
            else if (sales > 10000) comission = 0.13m;
            else goto label;
        }
        else if (town == "plovdiv")
        {
            if (sales >= 0 && sales <= 500) comission = 0.055m;
            else if (sales > 500 && sales <= 1000) comission = 0.08m;
            else if (sales > 1000 && sales <= 10000) comission = 0.12m;
            else if (sales > 10000) comission = 0.145m;
            else goto label;
        }

        else goto label;
       
        Console.WriteLine("{0:F2}", comission * sales);
    label:
        Console.WriteLine("error");
    }
}

