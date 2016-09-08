using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        int vowelsSum = 0;
        for (int i = 0; i < text.Length; i++)
        {
            char temp = text[i];
            switch (temp)
            {
                case 'a':
                    vowelsSum = vowelsSum + 1;
                    break;
                case 'e':
                    vowelsSum = vowelsSum + 2;
                    break;
                case 'i':
                    vowelsSum = vowelsSum + 3;
                    break;
                case 'o':
                    vowelsSum = vowelsSum + 4;
                    break;
                case 'u':
                    vowelsSum = vowelsSum + 5;
                    break;
                default:
                    vowelsSum = vowelsSum + 0; //consonant
                    break;
            }  
        }
        Console.WriteLine(vowelsSum);
    }
}

