using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    class Program
    {
        static void Main(string[] args)
        { 
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Properties.Settings.Default.UserName = GetUserName();
                Properties.Settings.Default.Save();
            }
                

            if (Properties.Settings.Default.UserAge == 0)
            {
                Properties.Settings.Default.UserAge = GetUserAge();
                Properties.Settings.Default.Save();
            }

            if (string.IsNullOrEmpty(Properties.Settings.Default.UserOccupation))
            {
                Properties.Settings.Default.UserOccupation = GetUserOccupation();
                Properties.Settings.Default.Save();
            }

            Console.WriteLine(Properties.Settings.Default.Greeting);
            ShowUserInformation();

            Console.ReadLine();
        }

        static string GetUserName()
        {
            Console.Write("Введите имя пользователя: ");
            string userName = Console.ReadLine();

            while (string.IsNullOrEmpty(userName))
            { 
                Console.Write("Неккоректный ввод. Введите имя пользователя: ");
                userName = Console.ReadLine();
            }

            return userName;
        }

        static int GetUserAge()
        {
            Console.Write("Введите возраст пользователя: ");
            string input = Console.ReadLine();
            int userAge;

            while (!int.TryParse(input, out userAge) || userAge <= 1)
            {
                Console.Write("Неккоректный ввод. Введите возраст пользователя: ");
                input = Console.ReadLine();
            }

            return userAge;
        }

        static string GetUserOccupation()
        {
            Console.Write("Введите род занятий пользователя: ");
            string userOccupation = Console.ReadLine();

            while (string.IsNullOrEmpty(userOccupation))
            {
                Console.Write("Неккоректный ввод. Введите род зпнятий пользователя: ");
                userOccupation = Console.ReadLine();
            }

            return userOccupation;
        }

        static void ShowUserInformation()
        {
            Console.WriteLine("Имя: " + Properties.Settings.Default.UserName);
            Console.WriteLine("Возраст: " + Properties.Settings.Default.UserAge);
            Console.WriteLine("Род занятий: " + Properties.Settings.Default.UserOccupation);
        }
    }
}
