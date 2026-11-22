using System;
using Tyuiu.YalalovNR.Sprint3.Task5.V17.Lib;
namespace Tyuiu.YalalovNR.Sprint3.Task1.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 12;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"Пределы i: от {startValue1} до {stopValue1}");
            Console.WriteLine($"Пределы k: от {startValue2} до {stopValue2}");

            double res = ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Сумма ряда = {res}");

            Console.ReadKey();
        }
    }
}