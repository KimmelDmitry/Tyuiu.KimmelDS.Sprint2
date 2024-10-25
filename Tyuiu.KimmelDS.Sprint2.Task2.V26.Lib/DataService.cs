using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KimmelDS.Sprint2.Task2.V26.Lib
{
    public class DataService : ISprint2Task2V26
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x >= 2 && x <= 5 && y == 2))
                return true;

            if ((x >= 2 && x <= 8 && y == 3))
                return true;

            if ((x >= 2 && x <= 6 && y == 4))
                return true;

            if ((x >= 5 && x <= 7 && y == 5))
                return true;

            if ((x >= 4 && x <= 7 && y == 6))
                return true;

            if ((x >= 5 && x <= 6 && y == 7))
                return true;

            if ((x >= 4 && x <= 10 && y == 8))
                return true;

            if ((x >= 7 && x <= 8 && y == 9))
                return true;

            if ((x >= 7 && x <= 9 && y == 10))
                return true;

            if ((x >= 7 && x <= 9 && y == 6)) return true;

                return false;
        }
    }
}
