using System;
using Tyuiu.YalalovNR.Sprint3.Task4.V27.Lib;
namespace Tyuiu.YalalovNR.Sprint1.Task7.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Начальное значение: {startValue}");
            Console.WriteLine($"Конечное значение: {stopValue}");

            double res = ds.Calculate(startValue, stopValue);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Сумма ряда = {res}");

            Console.ReadKey();
        }
    }
}