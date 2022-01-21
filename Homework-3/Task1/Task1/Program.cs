//Вывести элементы двумерного массива по диагонали
using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };

            Console.WriteLine("Весь массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.Write("Элементы диагонали: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                        Console.Write($"{array[i, j]} ");
                }
            }
        }
    }
}
