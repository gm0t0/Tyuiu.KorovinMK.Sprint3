using Tyuiu.KorovinMK.Sprint3.Task3.V24.Lib;
namespace Tyuiu.KorovinMK.Sprint3.Task3.V24;

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

        string value = "gft hggt ntg";
        char replaceable = 'g';
        char replacement = '*';



        Console.WriteLine("Строка: " + value);
        Console.WriteLine("Символ который заменяют:" + replaceable);
        Console.WriteLine("Символ которым заменяют:" + replacement);

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("Результат:                                                                  *");
        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("Строка после замены:" + ds.ReplaceCharInString(value, replaceable, replacement));

        Console.ReadLine();


    }
}

