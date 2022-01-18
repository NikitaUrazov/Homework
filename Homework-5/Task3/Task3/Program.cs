//Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.Write("Введите произвольные числа от 0 до 255: ");
            input = Console.ReadLine();

            string[] strNumbers = input.Split(' ');
            int[] intNumbers = new int[strNumbers.Length];

            for (int i = 0; i < strNumbers.Length; i++)
            {
                if (!int.TryParse(strNumbers[i], out intNumbers[i]) || intNumbers[i] < 0 || intNumbers[i] > 255)
                {
                    Console.WriteLine("Неккоректные входные данные.");
                    return;
                }
            }

            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("numbers.bin", FileMode.OpenOrCreate);
            formatter.Serialize(fileStream, intNumbers);

            // Чтение из bin файла
            fileStream.Position = 0;
            int[] newIntArray = (int[])formatter.Deserialize(fileStream);

            for (int i = 0; i < newIntArray.Length; i++)
                Console.WriteLine(newIntArray[i]);
        }
    }
}
