using Tbuiu.KimmelDS.Sprint2.Task1.V17.Lib;
namespace Tyuiu.KimmelDS.Sprint2.Task1.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Киммель Дмитрий Сергеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Операции сравнения                                                      *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Киммель Дмитрий Сергеевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу из операций сравнений (==, !=, <, >, <=, >=, последова*");
            Console.WriteLine("*ательность операций не должна нарушаться) и арифметических выражений, кот*");
            Console.WriteLine("*торая вернет логическую последовательность(массив): (True, True, True, Tr*");
            Console.WriteLine("*rue, True, False), при x = 1054, y = 375                                 *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int a = 135;
            int b = 123;
            int c = 455;
            int d = 321;

            DataService ds = new DataService();

            var result = ds.GetLogicOperations(a, b, c, d);
            Console.WriteLine(string.Join(", ",result.Select(x => x.ToString())));
            Console.ReadKey();
        }
    }
}