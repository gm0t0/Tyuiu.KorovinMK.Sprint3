using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KorovinMK.Sprint3.Task1.V11.Lib
{
    public class DataService : ISprint3Task1V11
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double MultiplySeries = 1;
            while (startValue <= stopValue)
            {
                MultiplySeries = MultiplySeries * (Math.Pow(value, startValue) + (1 / 2));
                startValue++;
            }
            return Math.Pow(MultiplySeries, 3);
        }
    }
}
