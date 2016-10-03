//using System;
//using System.Globalization;

//class HolidaysBetweenTwoDates
//{
//    static void Main()
//    {
//        var startDate = DateTime.ParseExact(Console.ReadLine(),
//            "dd.m.yyyy", CultureInfo.InvariantCulture);
//        var endDate = DateTime.ParseExact(Console.ReadLine(),
//            "dd.m.yyyy", CultureInfo.InvariantCulture);
//        var holidaysCount = 0;
//        for (var date = startDate; date <= endDate; date.AddDays(1))
//            if (date.DayOfWeek == DayOfWeek.Saturday &&
//                date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
//        Console.WriteLine(holidaysCount);
//    }
//}
//There are 4 mistakes in the code. 
//You’ve got to use the debugger to find them and fix them.
using System;

using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        //var startDate = DateTime.ParseExact(Console.ReadLine(),
        //    "dd.m.yyyy", CultureInfo.InvariantCulture);
        string userInput = Console.ReadLine();
        var startDate = DateTime.ParseExact(userInput,
           "d.M.yyyy", CultureInfo.InvariantCulture);

        //var endDate = DateTime.ParseExact(Console.ReadLine(),
        //    "dd.m.yyyy", CultureInfo.InvariantCulture);
        userInput = Console.ReadLine();
        var endDate = DateTime.ParseExact(userInput,
                   "d.M.yyyy", CultureInfo.InvariantCulture);

        //var holidaysCount = 0;
        var holidaysCount = 0;

        //for (var date = startDate; date <= endDate; date.AddDays(1))
        for (var date = startDate; date <= endDate; date = date.AddDays(1))

            //    if (date.DayOfWeek == DayOfWeek.Saturday &&
            //        date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
            if (date.DayOfWeek == DayOfWeek.Saturday ||
                   date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;

        //Console.WriteLine(holidaysCount);
        Console.WriteLine(holidaysCount);

    }
}
/*Mistakes:
 * m Минути от 0 до 59. --> М Месец във вид от 1 до 12.
 * && вместо ||  цикъла
 * date.AddDays(1)     --> date=date.AddDays(1)  не се увеличават дните
 * dd.m.yyyy --> d.M.yyyy  по-безопасно, ако използвате d/M/yyyy за формата
, тъй че ще се справят както едноцифрени и двуцифрени ден / месец.*/
