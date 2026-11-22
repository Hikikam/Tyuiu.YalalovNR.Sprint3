using System;
using Tyuiu.YalalovNR.Sprint3.Task6.V8.Lib;
namespace Tyuiu.YalalovNR.Sprint3.Task6.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 18;
            int stopValue = 28;

            Console.WriteLine($"Начало отрезка: {startValue}");
            Console.WriteLine($"Конец отрезка: {stopValue}");

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Сумма делителей больше 11 = {res}");

            Console.ReadKey();
        }
    }
}