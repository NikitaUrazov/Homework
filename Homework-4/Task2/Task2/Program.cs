// Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести результат на экран.
using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            string error;
            Console.Write("Введите числа, разделённые пробелами: ");
            string input = Console.ReadLine();
            if (IsInputCorrect(input, out sum, out error))
                Console.WriteLine(sum);
            else
                Console.WriteLine(error);
        }

        static bool IsInputCorrect(string input, out int sum, out string error)
        {
            string number = "";
            sum = 0;
            error = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    if (number != "")
                    {
                        sum += Convert.ToInt32(number);
                        number = "";
                    }
                }
                else
                {
                    if (Char.IsDigit(input[i]))
                        number += input[i];
                    else
                    {
                        error = "Incorrect input";
                        return false;
                    }
                }    
            }

            if (number != "")
                sum += Convert.ToInt32(number);
            return true;
        }
    }
}
