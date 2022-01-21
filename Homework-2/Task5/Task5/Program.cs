//Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».
using System;

namespace Task5
{
    public enum Months
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December,
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int temp;
            double temperatureMax, temperatureMin, temperatureAverage;
            Months numMonth;
            Console.Write("Введите порядковый номер месяца: ");
            input = Console.ReadLine();

            while (!int.TryParse(input, out temp))
            {
                Console.WriteLine("Ошибка. Некорректный формат.");
                Console.Write("Введите порядковый номер месяца: ");
                input = Console.ReadLine();
            }

            numMonth = (Months)temp;

            Console.Write("Введите максимальную температуру: ");
            input = Console.ReadLine();

            while (!double.TryParse(input, out temperatureMax))
            {
                Console.WriteLine("Ошибка. Некорректный формат.");
                Console.Write("Введите максимальную температуру: ");
                input = Console.ReadLine();
            }

            Console.Write("Введите минимальную температуру: ");
            input = Console.ReadLine();

            while (!double.TryParse(input, out temperatureMin))
            {
                Console.WriteLine("Ошибка. Некорректный формат.");
                Console.Write("Введите минимальную температуру: ");
                input = Console.ReadLine();
            }

            temperatureAverage = (temperatureMax + temperatureMin) / 2;

            if (numMonth > (Months)0 && numMonth <= (Months)3 && temperatureAverage > 0)
                Console.WriteLine("Дождливая зима.");
        }
    }
}
