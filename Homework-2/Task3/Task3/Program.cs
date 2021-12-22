//Определить, является ли введённое пользователем число чётным.
using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int digit;

            Console.Write("Введите целое число: ");
            input = Console.ReadLine();

            //Обработка неправильного формата ввода.
            while (!int.TryParse(input, out digit))
            {
                Console.WriteLine("Ошибка. Некорректный формат.");
                Console.Write("Ввелите целое число: ");
                input = Console.ReadLine();
            }

            if ((digit % 2) == 0)
                Console.WriteLine("Чётное");
            else
                Console.WriteLine("Нечётное");
        }
    }
}
