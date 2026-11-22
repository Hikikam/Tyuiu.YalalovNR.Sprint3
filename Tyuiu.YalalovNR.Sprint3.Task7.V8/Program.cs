using System;
using Tyuiu.YalalovNR.Sprint3.Task7.V8.Lib;

namespace Tyuiu.YalalovNR.Sprint3.Task7.V8
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

            Console.WriteLine($"Диапазон: от {startValue} до {stopValue}");
            Console.WriteLine($"Шаг: 1");

          
            double[] res = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ (ТАБЛИЦА ЗНАЧЕНИЙ):                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("|     x     |    F(x)   |");
            Console.WriteLine("|-----------|-----------|");

            int count = 0;
           
            for (int x = startValue; x <= stopValue; x++)
            {
               
                Console.WriteLine($"| {x,9} | {res[count],9} |");
                count++;
            }

            Console.WriteLine("|-----------|-----------|");

            Console.ReadKey();
        }
    }
}