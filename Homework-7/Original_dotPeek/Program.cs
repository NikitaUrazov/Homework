// Decompiled with JetBrains decompiler
// Type: Original.Program
// Assembly: Original, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 217EFAF7-CBC5-4678-BBBA-B86E4C94A93D
// Assembly location: D:\GeekBrains\Homework\Homework-7\Original\Original\bin\Debug\netcoreapp3.1\Original.dll

using System;

namespace Original
{
  internal class Program
  {
    private static void Main(string[] args)
    {
            Person[] personArray = new Person[4]
            {
        new Person()
        {
          LastName = "Соколов",
          FirstName = "Антон",
          Patronymic = "Дмитриевич"
        },
        new Person()
        {
          LastName = "Иванов",
          FirstName = "Василий",
          Patronymic = "Иванович"
        },
        new Person()
        {
          LastName = "Новиков",
          FirstName = "Сергей",
          Patronymic = "Сергеевич"
        },
        new Person()
        {
          LastName = "Уразов",
          FirstName = "Никита",
          Patronymic = "Сергеевич"
        }
      };
      Console.Write("Вход только по приглашениям. Ваше ФИО: ");
      string[] strArray = Console.ReadLine().Split(' ');
      if (strArray.Length != 3)
      {
        Console.WriteLine("Вы не проходите.");
      }
      else
      {
        for (int index = 0; index < personArray.Length; ++index)
        {
          if (strArray[0] == personArray[index].LastName && strArray[1] == personArray[index].FirstName && strArray[2] == personArray[index].Patronymic)
          {
            Console.WriteLine("Добро пожаловать, мистер " + personArray[index].LastName);
                        Console.ReadLine();
            return;
          }
        }
        Console.WriteLine("Вы не проходите.");
                Console.ReadLine();
      }
            Console.ReadLine();
    }
  }
}
