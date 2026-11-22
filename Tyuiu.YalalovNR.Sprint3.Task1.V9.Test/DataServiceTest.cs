using Microsoft.VisualStudio.TestTools.UnitTesting; // ОБЯЗАТЕЛЬНО ДЛЯ ТЕСТОВ
using Tyuiu.YalalovNR.Sprint3.Task1.V9.Lib;

namespace Tyuiu.YalalovNR.Sprint3.Task1.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 4;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

           
            double wait = 5815.752;

            Assert.AreEqual(wait, res);
        }
    }
}