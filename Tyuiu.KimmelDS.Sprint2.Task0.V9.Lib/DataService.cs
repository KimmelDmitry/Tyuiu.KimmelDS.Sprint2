using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KimmelDS.Sprint2.Task0.V9.Lib
{
    public class DataService : ISprint2Task0V9
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            return new bool[] { x == y, x != y, x < y, x > y, x <= y, x >= y };
        }
    }
}
