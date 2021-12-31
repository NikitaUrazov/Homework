//Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца. На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. 
//Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень). Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. 
//Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».

using System;

namespace Task3
{
    class Program
    {
        enum Seasons
        {
            Winter = 1,
            Spring,
            Summer,
            Autumn,
        }
        static void Main(string[] args)
        {
            Seasons season;
            if (!IsMonthCorrect(out season))
                return;
            WhichSeason(season);
        }

        static bool IsMonthCorrect(out Seasons season)
        {
            season = 0;

            Console.Write("Введите номер месяца: ");
            int monthNumber;

            if (!int.TryParse(Console.ReadLine(), out monthNumber))
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
                return false;
            }


            if (monthNumber > 0 && monthNumber < 13)
            {
                switch(monthNumber)
                {
                    case 1:
                        season = (Seasons)1;
                        break;
                    case 2:
                        season = (Seasons)1;
                        break;
                    case 3:
                        season = (Seasons)2;
                        break;
                    case 4:
                        season = (Seasons)2;
                        break;
                    case 5:
                        season = (Seasons)2;
                        break;
                    case 6:
                        season = (Seasons)3;
                        break;
                    case 7:
                        season = (Seasons)3;
                        break;
                    case 8:
                        season = (Seasons)3;
                        break;
                    case 9:
                        season = (Seasons)4;
                        break;
                    case 10:
                        season = (Seasons)4;
                        break;
                    case 11:
                        season = (Seasons)4;
                        break;
                    case 12:
                        season = (Seasons)1;
                        break;
                }
                return true;
            }
            else
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
                return false;
            }
        }
    
        static void WhichSeason(Seasons season)
        {
            switch (season)
            {
                case Seasons.Winter:
                    Console.WriteLine("Зима");
                    break;
                case Seasons.Spring:
                    Console.WriteLine("Весна");
                    break;
                case Seasons.Summer:
                    Console.WriteLine("Лето");
                    break;
                case Seasons.Autumn:
                    Console.WriteLine("Осень");
                    break;
            }
        }
    }
}
