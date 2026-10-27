using Tyuiu.KorovinMK.Sprint3.Task5.V5.Lib;
namespace Tyuiu.KorovinMK.Sprint3.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 10;
            int stopValue2 = 3;
            double res = ds.GetSumSumSeries(startValue1, startValue2, stopValue1, stopValue2);
            double wait = 0.687;
            Assert.AreEqual(wait, res);
        }
    }
}
