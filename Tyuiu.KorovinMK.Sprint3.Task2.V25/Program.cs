using Tyuiu.KorovinMK.Sprint3.Task2.V25.Lib;
namespace Tyuiu.KorovinMK.Sprint3.Task2.V25;

class Program
{

    public static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнлил: Коровин М. К| ИСНТб-26-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #3                                                                 *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
        Console.WriteLine("* Задание #2                                                                *");
        Console.WriteLine("* Вариант #25                                                               *");
        Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
        Console.WriteLine("*****************************************************************************");

        int value = 5;
        int startValue = 1;
        int stopValue = 13;

        Console.WriteLine("Переменная n:" + value);
        Console.WriteLine("Старт шага:" + startValue);
        Console.WriteLine("Конец шага:" + stopValue);

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Результат:                                                                  *");
        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("Произведение ряда:" + ds.GetSumSeries(value, startValue, stopValue));

        Console.ReadLine();


    }
}

