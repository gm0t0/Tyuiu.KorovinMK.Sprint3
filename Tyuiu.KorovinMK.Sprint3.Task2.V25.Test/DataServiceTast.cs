using Newtonsoft.Json.Linq;
using Tyuiu.KorovinMK.Sprint3.Task2.V25.Lib;
namespace Tyuiu.KorovinMK.Sprint3.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTast
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 13;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 17.016;
            Assert.AreEqual(wait, res);
        }
    }
}
