//Написать метод GetFullName(string firstName, string lastName, string patronymic), принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО. Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string error;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите имя: ");
                string firstName = Console.ReadLine();
                if (IsInputEmpty(firstName, out error))
                {
                    Console.WriteLine(error);
                    return;
                }    
                Console.Write("Введите фамилию: ");
                string lastName = Console.ReadLine();
                if (IsInputEmpty(lastName, out error))
                {
                    Console.WriteLine(error);
                    return;
                }
                Console.Write("Введите отчество: ");
                string patronymic = Console.ReadLine();
                if (IsInputEmpty(patronymic, out error))
                {
                    Console.WriteLine(error);
                    return;
                }

                Console.WriteLine(GetFullName(firstName, lastName, patronymic));
            }
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return firstName + " " + lastName + " " + patronymic;
        }

        static bool IsInputEmpty(string input, out string error)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                error = "Введённая строка пуста или состоит из пробелов";
                return true;
            }
            else
            {
                error = "";
                return false;
            }
        }
    }
}
