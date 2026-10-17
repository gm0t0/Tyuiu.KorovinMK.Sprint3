using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KorovinMK.Sprint3.Task0.V18.Lib
{
    public class DataService : ISprint3Task0V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double MultiplySeries = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                MultiplySeries = MultiplySeries * (Math.Pow((2.0 / (Math.Cos(value) + 0.5)), i));
            }
            return Math.Round(MultiplySeries, 3);
        }
    }
}
