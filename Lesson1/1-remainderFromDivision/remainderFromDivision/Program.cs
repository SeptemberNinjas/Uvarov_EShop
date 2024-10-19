//задача остаток от деления

//напишите простую программу для вывода результатов операции деления.

//создайте две целочисленные переменные - a и b.

//создайте третью целочисленную переменную, называемую quotient (результат деления),
//которая хранит результат деления a и b, и еще одну целочисленную переменную под названием remainder,
//которая хранит остаток (используя оператор %).

//выведите результаты с помощью console.writeline или console.write в следующем формате 
//(при условии что a = 17 и b = 4): 17 / 4 = 4 остаток 1

namespace remainderFromDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine(a + " / " + b + " = " + quotient + " остаток " + remainder);
        }
    }
}
