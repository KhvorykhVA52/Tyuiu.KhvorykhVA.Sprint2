using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KhvorykhVA.Sprint2.Task5.V2.Lib
{
    public class DataService : ISprint2Task5V2
    {
        public string FindMonthSeason(int month)
        {
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    return "Winter";
                case 3:
                case 4:
                case 5:
                    return "Spring";
                case 6:
                case 7:
                case 8:
                    return "Summer";
                case 9:
                case 10:
                case 11:
                    return "Autumn";
                default:
                    return "Invalid month";
            }
        }
    }
}
