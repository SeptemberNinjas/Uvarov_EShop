﻿/*Зарплата
В двумерном массиве хранится информация о зарплате 7ми человек за каждый месяц года 
(за январь — в первом столбце, за февраль — во втором и т. д.).

Определить общую зарплату, выплаченную в выбранном месяце.

Условия и ограничения:

- Элементы массива заранее заданы в коде программы
- Месяц, на который требуется рассчитать зарплату, должен вводиться через стандартный ввод
*/


using static System.Net.Mime.MediaTypeNames;

namespace Task6_salaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[,] salaries = new decimal[7, 12]
         {
            { 100000, 100001, 100000, 100000, 100000, 100000, 100000, 100000, 100001, 100000, 100000, 100000 },
            { 110000, 110000, 110001, 110000, 110000, 110000, 110000, 110000, 110000, 110001, 110000, 110000 },
            { 120000, 120000, 120000, 120001, 120000, 120000, 120000, 120000, 120000, 120000, 120001, 120000 },
            { 130000, 130000, 130000, 130000, 130001, 130000, 130000, 130000, 130000, 130000, 130000, 130001 },
            { 140000, 140000, 140000, 140000, 140000, 140001, 140000, 140000, 140000, 140000, 140000, 140000 },
            { 150000, 150000, 150000, 150000, 150000, 150000, 150001, 150000, 150000, 150000, 150000, 150000 },
            { 160000, 160000, 160000, 160000, 160000, 160000, 160000, 160001, 160000, 160000, 160000, 160000 }
         };

            Console.WriteLine("Введите номер месяца (1 - январь; ...;12 - декабрь):");
                        
            if (int.TryParse(Console.ReadLine(), out int month) && month >= 1 && month <= 12)
            {
                decimal totalSalary = CalculateTotalSalary(salaries, month - 1); 
                Console.WriteLine($"Общая зарплата за месяц {month}: {totalSalary}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста введите число от1 до12.");
            }
        }

        static decimal CalculateTotalSalary(decimal[,] salaries, int monthIndex)
        {
            decimal total = 0;

            for (int i = 0; i < salaries.GetLength(0); i++)
            {
                total += salaries[i, monthIndex];
            }

            return total;
        }
    }
}
