using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KhvorykhVA.Sprint2.Task1.V16.Lib
{
    public class DataService : ISprint2Task1V16
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a != c);
            res[1] = (b > a);
            res[2] = (a >= c);
            res[3] = (c < d);
            res[4] = (a < b && b > d);
            res[5] = (d >= b ^ a == c);
            return res;
        }
    }
}