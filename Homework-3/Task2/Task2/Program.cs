// Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/e-mail.
using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phoneBook = { { "Александров Б.Ю.", "88005553530" }, { "Синев М.С.", "88005553531" }, { "Дроздов М.Б.", "88005553532" }, { "Иванов А.А.", "88005553533" }, { "Рожков М.С.", "880005553534" } };

            for (int i = 0; i < phoneBook.GetLength(0); i++)
            {
                for (int j = 0; j < phoneBook.GetLength(1); j++)
                {
                    Console.Write($"{phoneBook[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
