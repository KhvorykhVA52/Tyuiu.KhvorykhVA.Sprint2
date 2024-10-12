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
                y = Math.Pow((x + 1) / (x - 1), x);
            }
            else if (x == 0)
            {
                y = Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) - 3;
            }
            else if (x > -34 && x < 2)
            {
                y = (1 / x) - Math.Sin(Math.Pow(x, 2)) - 2;
            }
            else if (x == -34)
            {
                y = 1 + (1 / x);
            }
            else if (x <= -34)
            {
                y = x + 10 * x - (4.0 / 3.0);
            }
            else
            {
                throw new ArgumentException("Invalid value for x");
            }

            return Math.Round(y, 3);
        }
    }
}
