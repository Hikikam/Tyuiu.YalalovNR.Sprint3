using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YalalovNR.Sprint3.Task6.V8.Lib;
namespace Tyuiu.YalalovNR.Sprint3.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetSumTheDivisorsTest()
        {
            DataService ds = new DataService();

            int startValue = 18;
            int stopValue = 28;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 292;

            Assert.AreEqual(wait, res);
        }
    }
}