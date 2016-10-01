using System;
using System.Linq;

public class Program
{

    public static void Main()
    {
        int input = Console.Read();
        int[] vowel = { 65, 69, 73, 79, 85, 89, 97, 101, 105, 111, 117, 121 };
        
        
        foreach (int i in vowel)
        {
            if (i.Equals(input))
            {
                Console.WriteLine("vowel");
                return; //край на програмата
            }
        }
        if (input > 47 && input < 58)
        {
            Console.WriteLine("digit");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}


