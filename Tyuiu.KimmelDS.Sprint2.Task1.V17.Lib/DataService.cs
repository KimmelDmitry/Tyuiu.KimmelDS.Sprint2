using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tbuiu.KimmelDS.Sprint2.Task1.V17.Lib
{
    public class DataService : ISprint2Task1V17
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
            => [!(a == b), a == b, !(a < b), !(d > c), d <= c, (d >= c)];
        //my res
        //True, False, True, True, True, False
        //but need
        //
        //Ожидалось: [true, false, true, true, true, false]
        //Получено: [false, true, true, false, false, true]
    }
}
