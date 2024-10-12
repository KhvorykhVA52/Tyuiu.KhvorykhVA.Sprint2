using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KhvorykhVA.Sprint2.Task3.V30.Lib
{
    public class DataService : ISprint2Task3V30
    {
        public double Calculate(double x)
        {
            double y;
            if (x > 1)
            {
                y = Math.Pow((x + 1) / (x - 1), x) * 5;
                Console.WriteLine($"Using case: x > 1, y = {y}");
            }
            else if (x == 0)
            {
                y = Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) - 3;
                Console.WriteLine($"Using case: x == 0, y = {y}");
            }
            else if (x > -34 && x < 2)
            {
                y = (1 / x) - Math.Sin(Math.Pow(x, 2)) - 2;
                Console.WriteLine($"Using case: -34 < x < 2, y = {y}");
            }
            else if (x == -34)
            {
                y = 1 + (1 / x);
                Console.WriteLine($"Using case: x == -34, y = {y}");
            }
            else if (x <= -34)
            {
                y = x + 10 * x - (4.0 / 3.0);
                Console.WriteLine($"Using case: x <= -34, y = {y}");
            }
            else
            {
                throw new ArgumentException("Invalid value for x");
            }

            return Math.Round(y, 3);
        }

    }
}
