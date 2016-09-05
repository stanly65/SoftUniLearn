using System;

class Program
{
    static void Main()
    {
        //Console.WriteLine("Enter birth date (dd-MM-yyyy):");
        String userInput = Console.ReadLine();

        DateTime birthDate = DateTime.ParseExact(userInput, "dd-MM-yyyy", null);
        DateTime userDate = birthDate.AddDays(999);
        string d = userDate.ToString("dd-MM-yyyy",
             System.Globalization.CultureInfo.InvariantCulture);
        Console.WriteLine(d);
    }
}

