using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.YalalovNR.Sprint3.Task6.V8.Lib
{
    public class DataService : ISprint3Task6V8
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sumd = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        if (d > 11)
                        {
                            sumd = sumd + d;
                        }
                    }
                }
            }
            return sumd;
        }
    }
}