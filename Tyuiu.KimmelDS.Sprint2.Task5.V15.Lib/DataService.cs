using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KimmelDS.Sprint2.Task5.V15.Lib
{
    public class DataService : ISprint2Task5V15
    {
        public string FindDayName(int k)
        {
            switch (k % 7)
            {
                case 0+1:
                    return "Понедельник";
                case 1+1:
                    return "Вторник";
                case 2+1:
                    return "Среда";
                case 3+1:
                    return "Четверг";
                case 4+1:
                    return "Пятница";
                case 5+1:
                    return "Суббота";
                case 0:
                    return "Воскресенье";
                default:
                    return "Ошибка";
            }
        }
    }
}
