using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KonovalovaAO.Sprint2.Task7.V3.Lib;
namespace Tyuiu.KonovalovaAO.Sprint2.Task7.V3
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила Коновалова А. О. /СМАРТб-23-1 ";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #3                                                             *");
            Console.WriteLine("* выполнила: Коновалова Александра Олеговна | СМАРТб-23-1                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные          *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами *");
            Console.WriteLine("* X,Y в заштрихованной области.                                          *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double x, y;
            Console.WriteLine("Введите значение переменной X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (res)
            {
                Console.WriteLine("Точка находиться в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находиться в заштрихованной области");
            }

            Console.ReadKey();

        }
    }
}
