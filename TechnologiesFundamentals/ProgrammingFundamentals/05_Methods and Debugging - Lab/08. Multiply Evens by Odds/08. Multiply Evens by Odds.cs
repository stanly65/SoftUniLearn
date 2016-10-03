using System;
using System.Text.RegularExpressions;

public class Program
{

    public static void Main()
    {
        string input = Console.ReadLine(); //чете втъведеното int число като стринг
        string dig = Regex.Replace(input, "[^0-9]", "");
        //dig = dig.Replace("-", ""); //отрязва минуса на отрицателните числа
        char[] chDigits = dig.ToCharArray();
        int[] digits = Array.ConvertAll(chDigits, c => (int)Char.GetNumericValue(c));

        int sumEvenDigits = 0;
        int sumOddDigits = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            
            if (digits[i] % 2 == 0) //четно
            {
                sumEvenDigits +=  digits[i];
            }
            else if (digits[i] % 2 != 0)
            {
                sumOddDigits += digits[i];
            }
            
        }
        Console.WriteLine(sumEvenDigits * sumOddDigits);
    }
}


