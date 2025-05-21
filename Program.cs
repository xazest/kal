using System;
using System.Linq;
using System.Text;
using ConsoleApp5;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            char[] choices = { '1', '2', '3', '4', '5' };

        Start:
            Console.WriteLine("     Курсы актуальны для 14.05.2025            Сейчас  " + DateTime.Today.ToString("dd.MM.yyyy"));
            Color.WriteColored($"\n{choices[0]} - Доллары($)     ", ConsoleColor.Green);
            Color.WriteColored($"{choices[1]} - Евро(€)     ", ConsoleColor.Blue);
            Color.WriteColored($"{choices[2]} - Рубли(₽)     ", ConsoleColor.Red);
            Color.WriteColored($"{choices[3]} - Гривны(₴)     ", ConsoleColor.DarkYellow);
            Color.WriteColored($"{choices[4]} - Леи(L) \n", ConsoleColor.Yellow, 1);

            char choice;
            do choice = Console.ReadKey(true).KeyChar;
            while (!choices.Contains(choice));

            if (choice == '1')
            {
                Console.WriteLine("1 - Купить      2 - Продать      3 - Назад\n");
                do { choice = Console.ReadKey(true).KeyChar; }
                while (!choices.Take(3).Contains(choice));
                {
                    if (choice == '1') Operations.MainOperation("usdsell");
                    else if (choice == '2') Operations.MainOperation("usdbuy");
                    else if (choice == '3') { Console.Clear(); goto Start; }
                }
            }

            else if (choice == '2')
            {
                Console.WriteLine("1 - Купить      2 - Продать      3 - Назад\n");
                do { choice = Console.ReadKey(true).KeyChar; }
                while (!choices.Take(3).Contains(choice));
                {
                    if (choice == '1') Operations.MainOperation("eursell");
                    else if (choice == '2') Operations.MainOperation("eurbuy");
                    else if (choice == '3') { Console.Clear(); goto Start; }
                }
            }

            else if (choice == '3')
            {
                Console.WriteLine("1 - Купить      2 - Продать      3 - Назад\n");
                do { choice = Console.ReadKey(true).KeyChar; }
                while (!choices.Take(3).Contains(choice));
                {
                    if (choice == '1') Operations.MainOperation("rubsell");
                    else if (choice == '2') Operations.MainOperation("rubbuy");
                    else if (choice == '3') { Console.Clear(); goto Start; }
                }
            }

            else if (choice == '4')
            {
                Console.WriteLine("1 - Купить      2 - Продать      3 - Назад\n");
                do { choice = Console.ReadKey(true).KeyChar; }
                while (!choices.Take(3).Contains(choice));
                {
                    if (choice == '1') Operations.MainOperation("uahsell");
                    else if (choice == '2') Operations.MainOperation("uahbuy");
                    else if (choice == '3') { Console.Clear(); goto Start; }
                }
            }

            else if (choice == '5')
            {
                Console.WriteLine("1 - Купить      2 - Продать      3 - Назад\n");
                do { choice = Console.ReadKey(true).KeyChar; }
                while (!choices.Take(3).Contains(choice));
                {
                    if (choice == '1') Operations.MainOperation("mdlsell");
                    else if (choice == '2') Operations.MainOperation("mdlbuy");
                    else if (choice == '3') { Console.Clear(); goto Start; }
                }
            }

            Console.WriteLine("\n1 - продолжить работу \n2 - закрыть программу");
            do choice = Console.ReadKey(true).KeyChar;
            while (!choices.Take(2).Contains(choice));
            if (choice == '1')
            {
                Console.Clear();
                goto Start;
            }

        }
    }
}