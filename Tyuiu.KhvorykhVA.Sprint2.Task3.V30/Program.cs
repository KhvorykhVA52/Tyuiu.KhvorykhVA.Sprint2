using System;
using Tyuiu.KhvorykhVA.Sprint2.Task3.V30.Lib;

namespace Tyuiu.KhvorykhVA.Sprint2.Task3.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Хворых В.А. | ACOиУБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                      *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Хворых Виктор Александрович | ACOиУБ-24-1                     *");
            Console.WriteLine("***************************************************************************");

            while (true)
            {
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* Введите значение x:                                                     *");
                Console.WriteLine("***************************************************************************");

                if (double.TryParse(Console.ReadLine(), out double x))
                {
                    try
                    {
                        double result = ds.Calculate(x);
                        Console.WriteLine("***************************************************************************");
                        Console.WriteLine($"* Результат: y = {result}                                                 *");
                        Console.WriteLine("***************************************************************************");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: введите корректное число.");
                }

                Console.WriteLine("Вы хотите ввести еще одно значение? (да/нет):");
                string continueInput = Console.ReadLine()?.ToLower();
                if (continueInput != "да")
                {
                    break;
                }
            }
        }
    }
}
