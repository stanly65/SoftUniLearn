using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int firstDigit = number / 10;
        int secondDigit = number % 10;
        int bothDigit = number;

        string sDigit = "";
        string fDigit = "";
        string bDigit = "";

        switch (secondDigit)
        {
            case 0: sDigit = "zero"; break;
            case 1: sDigit = "one"; break;
            case 2: sDigit = "two"; break;
            case 3: sDigit = "three"; break;
            case 4: sDigit = "four"; break;
            case 5: sDigit = "five"; break;
            case 6: sDigit = "six"; break;
            case 7: sDigit = "seven"; break;
            case 8: sDigit = "eight"; break;
            case 9: sDigit = "nine"; break;
        }

        switch (firstDigit)
        {
            case 2: fDigit = "twenty"; break;
            case 3: fDigit = "thirty"; break;
            case 4: fDigit = "fourty"; break;
            case 5: fDigit = "fifty"; break;
            case 6: fDigit = "sixty"; break;
            case 7: fDigit = "seventy"; break;
            case 8: fDigit = "eighty"; break;
            case 9: fDigit = "ninety"; break;
        }

        switch (bothDigit)
        {
            case 10: bDigit = "ten"; break;
            case 11: bDigit = "eleven"; break;
            case 12: bDigit = "twelve"; break;
            case 13: bDigit = "thirteen"; break;
            case 14: bDigit = "fourteen"; break;
            case 15: bDigit = "fifteen"; break;
            case 16: bDigit = "sixteen"; break;
            case 17: bDigit = "seventeen"; break;
            case 18: bDigit = "eighteen"; break;
            case 19: bDigit = "nineteen"; break;
        }

        if (number >= 0 && number < 10)
        {
            Console.WriteLine(sDigit);
        }
        else if (number > 9 && number < 20)
        {
            Console.WriteLine(bDigit);
        }
        else if (number > 19 && number < 101)
        {
            if (number % 10 == 0 && number != 100)
            {
                Console.WriteLine(fDigit);
            }
            else if (number == 100)
            {
                Console.WriteLine("one hundred");
            }
            else
            {
                Console.WriteLine(fDigit + " " + sDigit);
            }
        }
        else
        {
            Console.WriteLine("invalid number");
        }

    }
}

