//Задание с чеком
using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName ="СПОРТМАСТЕР";
            string cityName = "г. Пенза";
            string regionName = "Пензенская обл.";
            string storeAddress = "ул. Строителей, 1B";
            string storePhone = "8412210502";
            DateTime dateTimeOfPurchase = new DateTime(2021, 04, 20, 15, 57, 0);
            //Console.WriteLine(dateTimeOfPurchase.ToString("dd.MM.yy       HH:mm"));
            int checkNumber = 29;
            //Console.WriteLine(checkNumber.ToString("0000"));
            string bankName = "ПАО СБЕРБАНК";
            string operationType = "Оплата";
            string terminalNumber = "10812904";
            string merchantNumber = "480000078657";
            string cardType = "E1";
            string cardNumber = "************2820";
            double price = 3022;
            //Console.WriteLine(price.ToString(".00"));
            double comission = 0;
            string statusOfOperation= "ОДОБРЕННО";
            string authCode = "233638";
            string linkNumber = "111087211834";
            string methodOfPurchase = "Введен ПИН-код";
            string pin = "A311507B46F5CC7EFBF2EEF1656BE0AB3BBACF49";

            Console.WriteLine($"                {companyName}");
            Console.WriteLine($"         {cityName}, {regionName}");
            Console.WriteLine($"             {storeAddress}");
            Console.WriteLine($"               т. {storePhone}");
            Console.WriteLine($"{dateTimeOfPurchase.ToString("dd.MM.yy       HH:mm")}            ЧЕК {checkNumber.ToString("0000")}");
            Console.WriteLine($"{bankName}                      {operationType}");
            Console.WriteLine($"Терминал: {terminalNumber} Мерчант: {merchantNumber}");
            Console.WriteLine($"Карта: ({cardType})             {cardNumber}");
            Console.WriteLine($"Сумма (Руб):                     {price.ToString(".00")}");
            Console.WriteLine($"Комиссия за операцию - {comission} Руб.");
            Console.WriteLine($"                {statusOfOperation}");
            Console.WriteLine($"Код авторизации:                  {authCode}");
            Console.WriteLine($"Номер ссылки:               {linkNumber}");
            Console.WriteLine($"             {methodOfPurchase}");
            Console.WriteLine($"{pin}");
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
