/*
    Дни месяца
Составить программу, которая в зависимости от порядкового номера месяца (1, 2, ..., 12) и года 
выводит на экран количество дней в этом месяце. При вычисление количества дней учесть високосный год.

Год является високосным, если его номер кратен 4, однако из кратных 100 високосными являются лишь кратные 400, 
например, 
1700, 1800 и 1900 — невисокосные года, 
2000 — високосный. 

Условия и ограничения:

Значение номера месяца и год должны вводиться через стандартный ввод
Результаты вычисления вывести в стандартный вывод
Добавить проверку на корректность ввода данных
*/

using System;
using System.Security.Cryptography.X509Certificates;

namespace _10_months
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Input:
            Console.Write("Введите дату в формате ГГГГ.ММ (например, 2024.10): ");
            string YYYYMM = Console.ReadLine();

            bool check = DateTime.TryParseExact(YYYYMM, "yyyy-MM", null, System.Globalization.DateTimeStyles.None, out DateTime date);

            if (check)
            {
                Console.WriteLine($"Approved. Ввод: Год {date.Date}, Месяц {date.Month}");    
            }
            else {
                Console.WriteLine("Wasted!: Неверный формат даты. Используйте формат ГГГГ-ММ.");
                goto Input;
            }           
                        
            int days = DateTime.DaysInMonth(date.Year, date.Month);   
            
            Console.WriteLine($"В {date.Month} месяце: {days} дней.");

        }
    }
}
