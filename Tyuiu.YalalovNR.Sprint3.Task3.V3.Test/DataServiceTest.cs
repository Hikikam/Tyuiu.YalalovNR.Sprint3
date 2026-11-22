using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YalalovNR.Sprint3.Task3.V3.Lib;
namespace Tyuiu.YalalovNR.Sprint3.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetMinLengthTest()
        {
            DataService ds = new DataService();

            string str = "cvbmzff orffgtr dkfvfffd";
            char chr = 'f';
            int res = ds.GetMinCharCount(str,chr);
            int wait = 1;

            Assert.AreEqual(wait, res);
        }
    }
}