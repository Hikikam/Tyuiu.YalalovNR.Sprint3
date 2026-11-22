using System;
using Tyuiu.YalalovNR.Sprint3.Task3.V3.Lib;
namespace Tyuiu.YalalovNR.Sprint3.Task3.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите строку: ");
            string str = Console.ReadLine();

            int res = ds.GetMinCharCount(str);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Минимальное количество подряд идущих 'f': {res}");

            Console.ReadKey();
        }
    }
}