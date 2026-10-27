using Tyuiu.KorovinMK.Sprint3.Task6.V2.Lib;
namespace Tyuiu.KorovinMK.Sprint3.Task6.V2;

class Program
{

    public static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнлил: Коровин М. К| ИСНТб-26-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #3                                                                 *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
        Console.WriteLine("* Задание #6                                                                *");
        Console.WriteLine("* Вариант #2                                                                *");
        Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
        Console.WriteLine("*****************************************************************************");

        int startValue = 12;
        
        int stopValue = 18;


        Console.WriteLine("Промежуток на котором нужно найти колво делителей на целых числах;" + "[" + startValue + ";" + stopValue + "]");




        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Результат:                                                                  *");
        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("Сумма ряда:" + ds.GetSumTheDivisors(startValue, stopValue));

        Console.ReadLine();


    }
}

