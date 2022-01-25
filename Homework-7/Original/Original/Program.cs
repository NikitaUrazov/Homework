using System;

namespace Original
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] invites = { new Person() { LastName = "Соколов", FirstName = "Антон", Patronymic = "Дмитриевич" },
                new Person() { LastName = "Иванов", FirstName = "Василий", Patronymic = "Иванович" },
                new Person() { LastName = "Новиков", FirstName = "Сергей", Patronymic = "Сергеевич"}
            };

            Console.Write("Вход только по приглашениям. Ваше ФИО: ");
            string[] input = Console.ReadLine().Split(' ');
            
            if (input.Length != 3)
            {
                Console.WriteLine("Вы не проходите.");
                return;
            }

            for (int i = 0; i < invites.Length; i++)
            {
                if (input[0] == invites[i].LastName && input[1] == invites[i].FirstName && input[2] == invites[i].Patronymic)
                {
                    Console.WriteLine("Добро пожаловать, мистер " + invites[i].LastName);
                    return;
                }    
            }

            Console.WriteLine("Вы не проходите.");
        }
    }
}
