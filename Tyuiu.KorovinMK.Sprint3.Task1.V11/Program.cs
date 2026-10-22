using Tyuiu.KorovinMK.Sprint3.Task1.V11.Lib;
namespace Tyuiu.KorovinMK.Sprint3.Task1.V11;

class Program
{

    public static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнлил: Коровин М. К| ИСНТб-26-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #3                                                                 *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
        Console.WriteLine("* Задание #1                                                                *");
        Console.WriteLine("* Вариант #11                                                               *");
        Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
        Console.WriteLine("*****************************************************************************");

        double value = 0.75;
        int startValue = 1;
        int stopValue = 14;

        Console.WriteLine("Переменная X:" + value);
        Console.WriteLine("Старт шага:" + startValue);
        Console.WriteLine("Конец шага:" + stopValue);

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Результат:                                                                  *");
        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("Произведение ряда:" + ds.GetMultiplySeries(value, startValue, stopValue));

        Console.ReadLine();


    }
}

