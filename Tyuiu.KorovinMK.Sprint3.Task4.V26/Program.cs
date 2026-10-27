using Tyuiu.KorovinMK.Sprint3.Task4.V26.Lib;
namespace Tyuiu.KorovinMK.Sprint3.Task4.V26;

class Program
{

    public static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнлил: Коровин М. К| ИСНТб-26-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #3                                                                 *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
        Console.WriteLine("* Задание #4                                                                *");
        Console.WriteLine("* Вариант #26                                                               *");
        Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
        Console.WriteLine("*****************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("Старт шага:" + startValue);
        Console.WriteLine("Конец шага:" + stopValue);




        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Результат:                                                                  *");
        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("Сумма ряда:" + ds.Calculate(startValue, stopValue));

        Console.ReadLine();


    }
}

