using System;

class Program
{
    static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        string sex = Console.ReadLine();

        if (age <16)
        {
            if (sex=="m")
            {
                Console.WriteLine("Master");
            }
            else // dex== "f"
            {
                Console.WriteLine("Miss");
            }
        }
        else // age > 15
        {
            if (sex=="m")
            {
                Console.WriteLine("Mr.");
            }
            else // sex == "f"
            {
                Console.WriteLine("Ms.");
            }
        }     
    }
}

