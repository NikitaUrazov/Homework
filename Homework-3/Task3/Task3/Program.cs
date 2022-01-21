//Написать программу, выводящую введенную пользователем строку в обратном порядке (olleH вместо Hello).
using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            //Вывод на экран
            Console.Write("Строка в обратном порядке: ");
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();

            //Сохранение в другую строку и вывод на экран
            char[] reverseInput = new char[input.Length];

            for (int i = input.Length - 1, j = 0; i >= 0; i--, j++)
            {
                reverseInput[j] = input[i];
            }

            Console.Write("Вывод reverseInput: ");
            for (int i = 0; i < reverseInput.Length; i++)
            {
                Console.Write(reverseInput[i]);
            }
            Console.WriteLine();

            //Сохранил массив char в string
            string newString = new string(reverseInput);
            Console.WriteLine($"Вывод newString: {newString}");
        }
    }
}
