using System;
using Tyuiu.YalalovNR.Sprint3.Task1.V9.Lib;

namespace Tyuiu.YalalovNR.Sprint3.Task1.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение x (по условию задачи x = 5): ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите начальное значение k (startValue): ");
            int startValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите конечное значение k (stopValue): ");
            int stopValue = Convert.ToInt32(Console.ReadLine());

            double res = ds.GetMultiplySeries(x, startValue, stopValue);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Произведение ряда = {res}");

            Console.ReadKey();
        }
    }
}