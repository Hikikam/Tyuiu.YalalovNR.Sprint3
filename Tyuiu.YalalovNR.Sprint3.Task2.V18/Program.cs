using System;
using Tyuiu.YalalovNR.Sprint3.Task2.V18.Lib;

namespace Tyuiu.YalalovNR.Sprint3.Task2.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение x (по условию x = 1): ");
            int value = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите начальное значение k: ");
            int startValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите конечное значение k: ");
            int stopValue = Convert.ToInt32(Console.ReadLine());

         
            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Произведение ряда = {res}");

            Console.ReadKey();
        }
    }
}