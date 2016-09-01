using System;

class Program
{
    static void Main()
    {
        /* Прочита въведеното в конзолата го превърща (парсва)
         от string в число от тип byte
         и го записва в променливата "n"*/
        byte n = byte.Parse(Console.ReadLine());

        // условие за квадратa
        if ((2 <= n) && (n <= 100))
        {
            
             //горен ред на квадрата със стрна "n"*
            Console.WriteLine(new string('*', n));

            // иницилизация; булево условие; обновяване на брояча
            for (byte i = 0; i < (n - 2); i++)
            {
                Console.Write("*"); //  * в начало на реда
                Console.Write(new string(' ', n - 2));//n-2 празни интервали
                Console.WriteLine("*");// * в края на реда и минаване на нов ред
            }

            // долен ред на квадрата със стрна "n"
            Console.WriteLine(new string('*', n));

        }
    }
}

