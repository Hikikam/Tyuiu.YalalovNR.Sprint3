using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YalalovNR.Sprint3.Task1.V9.Lib
{
    public class DataService : ISprint3Task1V9
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double MultSeries = 1;

            while (startValue <= stopValue)
            {
             
                MultSeries = MultSeries * Math.Pow(300.0 / (Math.Cos(value) + Math.Pow(value, startValue)), startValue);
                startValue++;
            }

            return Math.Round(MultSeries, 3);
        }
    }
}