﻿using System;

public class Program
{

    public static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int final = int.Parse(Console.ReadLine());
        
        for (int i =start; i <= final; i++)
        {
            Console.Write((char)i+" ");
        }
    }
}


