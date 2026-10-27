using Tyuiu.KorovinMK.Sprint3.Task7.V10.Lib;
namespace Tyuiu.KorovinMK.Sprint3.Task7.V10;

class Program
{

    public static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнлил: Коровин М. К| ИСНТб-26-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #3                                                                 *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
        Console.WriteLine("* Задание #7                                                                *");
        Console.WriteLine("* Вариант #10                                                               *");
        Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
        Console.WriteLine("*****************************************************************************");

        int startValue = -5;

        int stopValue = 5;

        Console.WriteLine("Старт шага;" + startValue);
        Console.WriteLine("Конец шага;" + stopValue);

        int len = ds.GetMassFunction(startValue, stopValue).Length;

        double[] valueArray;
        valueArray = ds.GetMassFunction(startValue, stopValue);


        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Результат:                                                                  *");
        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("+------------------+");
        Console.WriteLine("|        |         |");
        Console.WriteLine("|    X   |  f(x)   |");
        Console.WriteLine("|        |         |");
        Console.WriteLine("+------------------+");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine("|{0,3:d}     | {1, 3:f2}  |", startValue, valueArray[i]);
            startValue++;
        }
        Console.WriteLine("+------------------+");
        Console.ReadKey();

    }
}

