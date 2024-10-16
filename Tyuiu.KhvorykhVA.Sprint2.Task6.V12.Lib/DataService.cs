using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KhvorykhVA.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            if (n == 1)
            {
                if (m == 1)
                {
                    g -= 1;
                    m = 12;
                    n = 31;
                }
                else
                {
                    m -= 1;
                    n = DateTime.DaysInMonth(g, m);
                }
            }
            else
            {
                n -= 1;
            }

            return n.ToString("D2") + "." + m.ToString("D2") + "." + g.ToString();
        }
    }
}