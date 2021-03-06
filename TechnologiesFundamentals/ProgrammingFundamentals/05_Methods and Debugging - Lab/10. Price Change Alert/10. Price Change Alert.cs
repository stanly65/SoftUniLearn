﻿using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());
        decimal thresholdPrice = decimal.Parse(Console.ReadLine());
        decimal lastPrice = decimal.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            decimal currentPrice = decimal.Parse(Console.ReadLine());
            decimal diff = GetPercentageDiff(lastPrice, currentPrice);
            bool isSignificant = IsSignificantDiff(diff, thresholdPrice);
            string message = GetMessage(currentPrice, lastPrice, diff, isSignificant);
            Console.WriteLine(message);
            lastPrice = currentPrice;
        }
    }

    public static string GetMessage(decimal current, decimal last, decimal diff, bool isSignif)
    {
        string message = "";
        decimal diffInPercent = diff * 100;
        //decimal eps = 0.000001m;

        if (Math.Abs(diff) == 0)
        {
            message = string.Format("NO CHANGE: {0}", current);
        }
        else if (!isSignif && Math.Abs(diff) > 0)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, current, diffInPercent);
        }
        else if (isSignif && (diff > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, current, diffInPercent);
        }
        else if (isSignif && (diff < 0))
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, current, diffInPercent);

        return message;
    }

    public static bool IsSignificantDiff(decimal diff, decimal thresholdPrice)
    {
        if (Math.Abs(diff) < thresholdPrice)
        {
            return false;
        }
        return true;
    }

    public static decimal GetPercentageDiff(decimal last, decimal current)
    {
        decimal diff = (current - last) / last;
        return diff;
    }
}