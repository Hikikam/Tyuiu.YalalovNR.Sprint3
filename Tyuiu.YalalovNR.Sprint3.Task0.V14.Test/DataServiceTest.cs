using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YalalovNR.Sprint3.Task0.V14.Lib;
namespace Tyuiu.YalalovNR.Sprint3.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 2;     
            int startValue = 1; 
            int stopValue = 5;  

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 14400; 

            Assert.AreEqual(wait, res);
        }
    }
}