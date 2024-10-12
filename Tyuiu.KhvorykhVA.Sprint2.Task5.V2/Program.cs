using Tyuiu.KhvorykhVA.Sprint2.Task5.V2.Lib;
using System;

namespace Tyuiu.KhvorykhVA.Sprint2.Task5.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер месяца (от 1 до 12): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int month))
            {
                string season = ds.FindMonthSeason(month);

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine($"Месяц {month} относится к времени года: {season}");
            }
            else
            {
                Console.WriteLine("Ошибка: Введено некорректное значение. Пожалуйста, введите число от 1 до 12.");
            }
        }
    }
}
