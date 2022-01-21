//Для полного закрепления битовых масок, попытайтесь создать универсальную структуру расписания недели, к примеру, чтобы описать работу какого либо офиса. 
//Явный пример - офис номер 1 работает со вторника до пятницы, офис номер 2 работает с понедельника до воскресенья и выведите его на экран консоли.
using System;

namespace Task6
{
    [Flags]
    public enum Schedule
    {
        Monday    = 0b_0000001,
        Tuesday   = 0b_0000010,
        Wednesday = 0b_0000100,
        Thursday  = 0b_0001000,
        Friday    = 0b_0010000,
        Saturday  = 0b_0100000,
        Sunday    = 0b_1000000,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Schedule office1 = (Schedule)0, office2 = (Schedule)0;
            office1 = office1 | Schedule.Tuesday | Schedule.Wednesday | Schedule.Thursday | Schedule.Friday;
            office2 = Schedule.Monday | Schedule.Tuesday | Schedule.Wednesday | Schedule.Thursday | Schedule.Friday | Schedule.Saturday | Schedule.Sunday;

            Console.WriteLine($"Office 1 is working on {office1}.");
            Console.WriteLine($"Office 2 is working on {office2}.");
            Console.WriteLine();

            //Проверка работы по дням.
            string input;
            Schedule mask = 0;
            bool isInputCorrect = false;

            //Цикл чтобы программа не завершалась при неправильном вводе, а ждала правильный
            while (!isInputCorrect)
            {
                Console.Write("Enter day of the week: ");
                input = Console.ReadLine();

                switch (input)
                {
                    default:
                        Console.WriteLine("Error. Incorrect input.");
                        Console.WriteLine();
                        break;
                    case "Monday":
                        isInputCorrect = true;
                        mask = Schedule.Monday;
                        break;
                    case "Tuesday":
                        isInputCorrect = true;
                        mask = Schedule.Tuesday;
                        break;
                    case "Wednesday":
                        isInputCorrect = true;
                        mask = Schedule.Wednesday;
                        break;
                    case "Thursday":
                        isInputCorrect = true;
                        mask = Schedule.Thursday;
                        break;
                    case "Friday":
                        isInputCorrect = true;
                        mask = Schedule.Friday;
                        break;
                    case "Saturday":
                        isInputCorrect = true;
                        mask = Schedule.Saturday;
                        break;
                    case "Sunday":
                        isInputCorrect = true;
                        mask = Schedule.Sunday;
                        break;
                    
                }
            }

            Console.WriteLine();

            if ((office1 & mask) == mask)
                Console.WriteLine($"Office 1 is working on {mask}");
            else
                Console.WriteLine($"Office 1 is not working on {mask}");

            if ((office2 & mask) == mask)
                Console.WriteLine($"Office 2 is working on {mask}");
            else
                Console.WriteLine($"Office 2 is not workint on {mask}");

        }
    }
}
