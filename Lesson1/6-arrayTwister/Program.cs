/*
 * Задача перевернуть массив
Давайте сделаем программу, которая использует методы для выполнения задачи. 
Давайте возьмем массив и перевернём его содержимое в обратном порядке. 

Например, если у вас массив 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 
то результатом будет 10, 9, 8, 7, 6, 5, 4, 3, 2, 1. 

Чтобы добиться этого, вы создадите три метода: 
 - один для создания массива, 
 - один для его переворачивания
 - один для вывода массива в конце.

Ваш метод Main будет выглядеть примерно так:

static void Main(string args)
{
    int numbers = ArrayCreator();
    Reverse(numbers);
    PrintNumbers(numbers);
}
Метод ArrayCreator должен вернуть массив из 10 случайных чисел 
(бонусное условие - метод должен принимать в качестве аргумента длину желаемого массива). 

 - Метод PrintNumbers должен использовать цикл for или foreach для вывода каждого элемента массива. 
 - Метод Reverse будет делать основную работу - переворачивать массив.

Реализуйте все три метода
*/

using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace _6_arrayTwister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввидите желаемую длину массива: ");
            string arrWishLengthStr = Console.ReadLine();
            int arrWishLength = int.Parse(arrWishLengthStr);

            int[] numbers = ArrayCreator(arrWishLength);
            int[] myArrReversed = Reverse(numbers);
            PrintNumbers(myArrReversed);

        }
        static int[] ArrayCreator(int arrLength)
        {
            
            Random random = new Random();
            int[] myArr = new int[arrLength];

            Console.Write($"Воть исходный массив: ");

            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = random.Next(1, 1000);
                Console.Write(myArr[i] + " ");
            }
            Console.Write(Environment.NewLine);
            return myArr;
        }

        static int[] Reverse(int[] numbers)
        {
            int[] myArrReversed = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                myArrReversed[i] = numbers[numbers.Length - i - 1];
            }
            return myArrReversed;
        }


        static void PrintNumbers (int[] numbers)
        {
            Console.Write("Воть перевернутый массив: ");
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
        }


    }
}
