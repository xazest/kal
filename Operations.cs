using System;

namespace ConsoleApp5
{
    public class Operations
    {
        static char currencySymbol;
        static float amountOfMoney;
        static float result;
        static string action;

        public static void MainOperation(string operation)
        {
            CurrencySymbolFinding(operation);
            Console.Write($"Введите нужное количество {currencySymbol}: ");
        Again:
            float.TryParse(Console.ReadLine(), out amountOfMoney);
            if (amountOfMoney <= 0) { Console.Write("ты че ахуел давай еще раз, сколько "); goto Again; }
            result = amountOfMoney * Exchange.GetRates(operation);
            ActionFinding(operation);
            Console.WriteLine(action);
        }
        public static void CurrencySymbolFinding(string operation)
        {
            if (operation.Contains("usd")) currencySymbol = '$';
            else if (operation.Contains("eur")) currencySymbol = '€';
            else if (operation.Contains("rub")) currencySymbol = '₽';
            else if (operation.Contains("uah")) currencySymbol = '₴';
            else if (operation.Contains("mdl")) currencySymbol = 'L';
        }
        public static void ActionFinding(string operation)
        {
            if (operation.Contains("sell"))
                action = $"\nДля покупки {amountOfMoney}{currencySymbol} вам потребуется {result} рублей ПМР";

            else if (operation.Contains("buy"))
                action = $"\nПосле продажи {amountOfMoney}{currencySymbol} вы получите {result} рублей ПМР";
        }
    }
}