using Tyuiu.KhvorykhVA.Sprint2.Task6.V12.Lib;
namespace Tyuiu.KhvorykhVA.Sprint2.Task6.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил Хворых В. А. | АСОиУБ-24-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #2                                                                   *");
            Console.WriteLine("* Тема: Базовые навыки работы в с#                                            *");
            Console.WriteLine("* Задание #6                                                                  *");
            Console.WriteLine("* Вариант #12                                                                 *");
            Console.WriteLine("* Выполнил Хворых Виктор Александрович | АСОиУБ-24-1                          *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи оператора   *");
            Console.WriteLine("* switch вычисляет требуемое значение и возвращает результат                  *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            int g, m, n;
            Console.WriteLine("Введите первое значение : ");
            g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе значение : ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье значение : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine($"Ответ : {ds.FindDateOfPreviousDay(g, m, n)}");
            Console.ReadKey();
        }
    }
}