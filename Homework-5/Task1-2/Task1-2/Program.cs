//Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
//Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
using System;
using System.IO;

namespace Task1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "startup.txt";
            string input;

            Console.Write("Введите строку: ");
            input = Console.ReadLine();

            if (input == null)
            {
                Console.WriteLine("Ошибка. Пустая строка.");
                return;
            }

            File.WriteAllText(fileName, input);

            string date = Convert.ToString(DateTime.Now);

            File.AppendAllText(fileName, Environment.NewLine);
            File.AppendAllText(fileName, date.Split(' ')[0]); // Число
            File.AppendAllText(fileName, Environment.NewLine);
            File.AppendAllText(fileName, date.Split(' ')[1]); // Время

        }
    }
}
