//Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperatureMax, temperatureMin, temperatureAverage;
            string input;

            Console.Write("Введите макимальную температуру: ");
            input = Console.ReadLine();

            // Обработка неправильного формата ввода. Пример правильного: 36,6
            while (!double.TryParse(input, out temperatureMax))
            {
                Console.WriteLine("Ошибка: Неккоректный формат.");
                Console.Write("Введите макимальную температуру: ");
                input = Console.ReadLine();
            }

            Console.Write("Введите минимальную температуру: ");
            input = Console.ReadLine();

            while (!double.TryParse(input, out temperatureMin))
            {
                Console.WriteLine("Ошибка: Неккоректный формат.");
                Console.Write("Введите минимальную температуру: ");
                input = Console.ReadLine();
            }

            temperatureAverage = (temperatureMax + temperatureMin) / 2;
            Console.WriteLine($"Среднее значение температуры: {temperatureAverage}");
        }
    }
}
