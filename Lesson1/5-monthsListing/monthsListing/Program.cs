//using System;

//Задача перечисление месяцев
//Используя перечисление (enum) DaysOfWeek в качестве примера,
//    создайте перечисление для представления месяцев года. 
//    Присвойте им значения от 1 до 12. Напишите программу,
//    которая попросит пользователя ввести число от 1 до 12. 
//    Убедитесь, что пользователь ввёл значение в нужном диапазоне и 
//    используйте явное приведение типа для преобразования числа в созданный 
//    вами enum. Затем выведите название месяца в консоль.


using System;
using System.Text.RegularExpressions;
using System.Text;
namespace monthsListing
{
    enum MonthsOfYear
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 12, чтобы узнать название месяца:");
            
            string input = Console.ReadLine();
            int monthNumber;

            
            if (int.TryParse(input, out monthNumber) && monthNumber >= 1 && monthNumber <= 12)
            {
                
                MonthsOfYear month = (MonthsOfYear)monthNumber;

                
                Console.WriteLine($"Месяц: {month}");
            }
            else
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12.");
            }
        }
    }
}
