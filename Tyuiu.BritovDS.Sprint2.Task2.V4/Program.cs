using Tyuiu.BritovDS.Sprint2.Task2.V4.Lib;

namespace Tyuiu.BritovDS.Sprint2.Task2.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Бритов Д. С. | ИСПб 25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                                ");
            Console.WriteLine("* Тема: Организация ввода вывода в консольных приложениях                  ");
            Console.WriteLine("* Задание #2                                                               ");
            Console.WriteLine("* Вариант #24                                                              ");
            Console.WriteLine("* Выполнил: Бритов Д. С. | ИСПб 25-1                                       ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения                ");
            Console.WriteLine("* с клавиатуры и вычисляет находится ли точка с координатами X,Y в         ");
            Console.WriteLine("* заштрихованной области.                                                  ");
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* Введите значние х:                                                       ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("* Введите значние y:                                                       ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.CheckDotInShadedArea(x, y));

            Console.ReadKey();
        }
    }
}