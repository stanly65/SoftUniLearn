using System;

public class Program
{

    public static void Main()
    {
        var type = Console.ReadLine();
        if (type == "int")
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int max = GetMax(first, second);
            Console.WriteLine(max);
        }
        else if (type == "char")
        {
            char first = Convert.ToChar(Console.Read());
            Console.Read(); //consume carrige return
            Console.Read(); //consume carrige return
            char second = Convert.ToChar(Console.Read());
            char max = GetMax(first, second);
            Console.WriteLine(max);
        }
        else if (type == "string")
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string max = GetMax(first, second);
            Console.WriteLine(max);
        }
    }

    static int GetMax(int first, int second)
    {
        int result;
        if (first>=second)
        {
           result = first;
        }
        else
        {
            result = second;
        }
        return result;
    }

    static char GetMax(char first,char second)
    {
        char result;
        if (first >= second)
        {
            result = first;
        }
        else
        {
            result = second;
        }
        return result;
    }

    static string GetMax(string first,string second)
    {
        string result;
        if (first.CompareTo(second) >= 0)
        {
            result = first;
        }
        else
        {
            result = second;
        }
        return result;
    }
}


