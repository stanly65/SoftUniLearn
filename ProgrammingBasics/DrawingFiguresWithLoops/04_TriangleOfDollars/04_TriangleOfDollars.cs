using System;

class Program
{
    static void Main()
    {
        //Да се напише програма, която въвежда число n
        //и печата триъгълник от долари ($ $ )
        int n = int.Parse(Console.ReadLine());
        string dolar = "$";
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(dolar);
            dolar += " $";
        }
    }
}

