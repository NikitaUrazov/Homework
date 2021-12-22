//Запросить у пользователя порядковый номер текущего месяца и вывести его название.
using System;

namespace Task2
{
    public enum Months
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Months numMonth;
            string input;
            int temp;
            Console.Write("Введите порядковый номер месяца: ");
            input = Console.ReadLine();

            //Обработка неправильного формата ввода. 
            while (!int.TryParse(input, out temp))
            {
                Console.WriteLine("Ошибка. Неверный формат.");
                Console.Write("Введите порядковый номер месяца: ");
                input = Console.ReadLine();
            }

            if (temp > 0 && temp <= 12)
            {
                numMonth = (Months)temp;
                Console.WriteLine(numMonth);
            }
            else
                Console.WriteLine("Такого месяца нет.");
        }
    }
}