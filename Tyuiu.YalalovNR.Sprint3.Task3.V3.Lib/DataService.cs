using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YalalovNR.Sprint3.Task3.V3.Lib
{
    public class DataService : ISprint3Task3V3
    {
        public int GetMinCharCount(string str, char item)
        {
            int count = 0;
            int min = 100;

            foreach (char c in str + " ")
            {
                if (c == item)
                {
                    count++;
                }
                else
                {
                    if (count > 1 && count < min)
                    {
                        min = count;
                    }
                    count = 0;
                }
            }
            return min;
        }
    }
}