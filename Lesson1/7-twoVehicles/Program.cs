/*
 Два автомобиля едут друг за другом с постоянными скоростями V1 и V2 км/час. 
Определить, какое расстояние будет между ними через 30 минут после того, 
как первый автомобиль опередил второй на S км.

Условия и ограничения:

Значения V1, V2, S - должны вводиться через стандартный ввод.
Результат вывести в стандартный вывод.
 */

namespace _6_twoVehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Speed:
            Console.Write("Введите скорость первого автомобиля (V1) в км/ч: ");
            int V1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите скорость второго автомобиля (V2) в км/ч: ");
            int V2 = Convert.ToInt32(Console.ReadLine());

            if (V1 <= V2)
            {
                Console.WriteLine("Первый автомобиль должен быть быстрее второго.");
                goto Speed;
            }
            
            Console.Write("Расстояние (S) в км, на которое первый автомобиль опередил второй: ");
            
            int S = Convert.ToInt32(Console.ReadLine());
            double timeInHours = 0.5;
            double distanceFirstCar = V1 * timeInHours;
            double distanceSecondCar = V2 * timeInHours;
            double distanceBetweenCars = S + (distanceFirstCar - distanceSecondCar);

            Console.WriteLine($"Расстояние между автомобилями через 30 минут: {distanceBetweenCars} км");
        }
    }
}
