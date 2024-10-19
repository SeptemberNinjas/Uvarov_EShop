﻿/*
Задача FizzBuzz
Задача состоит в том, чтобы вывести все числа от 1 до 100. 
Но если число является кратным 3, вместо него следует вывести слово «Fizz». 
Если число кратно 5, выводим «Buzz». 
Если число кратно как 3, так и 5 (например, 15 или 30), то выводим «FizzBuzz». 
Например, «1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz...»
*/
 
namespace _2_fizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[]
                {
                    1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                    11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                    21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
                    31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
                    41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
                    51, 52, 53, 54, 55, 56, 57, 58, 59, 60,
                    61, 62, 63, 64, 65, 66, 67, 68, 69, 70,
                    71, 72, 73, 74, 75, 76, 77, 78, 79, 80,
                    81,82 ,83 ,84 ,85 ,86 ,87 ,88 ,89 ,90,
                    91 ,92 ,93 ,94 ,95 ,96 ,97 ,98 ,99 ,100
                };

            for (int i = 0; i < myArr.Length; i++)
            {
                if (myArr[i] % 3 == 0 && myArr[i] % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz ");
                }
                else if (myArr[i] % 3 == 0)
                {
                    Console.WriteLine("Fizz ");
                }
                else if (myArr[i] % 5 == 0)
                {
                    Console.WriteLine("Buzz ");
                } 
                else
                {
                    Console.WriteLine($"{myArr[i]} ");
                }
            }
        }
    }
}
