﻿using System;

public class Program
{

    public static void Main()
    {
        double x1 = double.Parse(Console.ReadLine()); //Координати отсечка точки 1-2
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double x3 = double.Parse(Console.ReadLine()); // Координати отсечка точки 3-4
        double y3 = double.Parse(Console.ReadLine());
        double x4 = double.Parse(Console.ReadLine());
        double y4 = double.Parse(Console.ReadLine());

        double firstSecondPointLength = GetDistanceBetweenTwoPoints(x1, y1, x2, y2); //Дължина  отсечка точки 1-2
        double thirdFourthPointLength = GetDistanceBetweenTwoPoints(x3, y3, x4, y4); //Дължина  отсечка точки 3-4

        double firstPointCloser = GetDistanceBetweenTwoPoints(x1, y1, 0, 0);         //Отдалеченост на т.1 от център (0,0)
        double secondPointCloser = GetDistanceBetweenTwoPoints(x2, y2, 0, 0);        //Отдалеченост на т.2 от център (0,0)
        double thirdPointCloser = GetDistanceBetweenTwoPoints(x3, y3, 0, 0);         //Отдалеченост на т.3 от център (0,0)
        double fourthPointCloser = GetDistanceBetweenTwoPoints(x4, y4, 0, 0);        //Отдалеченост на т.4 от център (0,0)

        if (firstSecondPointLength > thirdFourthPointLength)      // koя отсечка е по-дълга
        {
            if (firstPointCloser < secondPointCloser)             // коя точка е по-близо до центъра 
            {

                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");  // печатаме първо по-близката до центъра точка на по-дългата отсечка         
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }

        }
        else if (firstSecondPointLength < thirdFourthPointLength)
        {

            if (thirdPointCloser < fourthPointCloser)
            {
                Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
            }
            else
            {
                Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
            }
        }
        else if (firstSecondPointLength == thirdFourthPointLength)
        {
            if (firstPointCloser < secondPointCloser)
            {
                // печатаме първо по-близката до център точка на по-дългата линия
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }

    static double GetDistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
    {
        //√(x2−x1)2+(y2−y1)2
        double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        return distance;
    }
}

