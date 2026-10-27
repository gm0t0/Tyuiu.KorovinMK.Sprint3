using Tyuiu.KorovinMK.Sprint3.Task5.V5.Lib;
namespace Tyuiu.KorovinMK.Sprint3.Task5.V5;

class Program
{

    public static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнлил: Коровин М. К| ИСНТб-26-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #3                                                                 *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
        Console.WriteLine("* Задание #5                                                                *");
        Console.WriteLine("* Вариант #5                                                                *");
        Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
        Console.WriteLine("*****************************************************************************");

        int x = 5;
        int startValue1 = 1;
        int startValue2 = 1;
        int stopValue1 = 3;
        int stopValue2 = 10;

        Console.WriteLine("Значение переменной X" + x);
        Console.WriteLine("Старт шага1:" + startValue1);
        Console.WriteLine("Конец шага1:" + stopValue1);
        Console.WriteLine("Старт шага2:" + startValue2);
        Console.WriteLine("Конец шага2:" + stopValue2);




        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Результат:                                                                  *");
        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("Сумма ряда:" + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

        Console.ReadLine();


    }
}

