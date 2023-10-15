using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KonovalovaAO.Sprint2.Task4.V15.Lib;
namespace Tyuiu.KonovalovaAO.Sprint2.Task4.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила Коновалова А. О. /СМАРТб-23-1 ";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Тернарный оператор                                               *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #15                                                            *");
            Console.WriteLine("* выполнила: Коновалова Александра Олеговна | СМАРТб-23-1                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с             *");
            Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значение  *");
            Console.WriteLine("* переменной X, Y с клавиатуры, если sqrt(x) / 2 > sqrt(y) - 20, то      *");
            Console.WriteLine("*     (      2 )^x                   12                                  *");
            Console.WriteLine("* z = ( 3 + ---)   , иначе cos(y) + ----                                 *");
            Console.WriteLine("*     (     x^2)                     x^2                                 *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double x, y;
            Console.Write("Введите значение переменной X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение переменной Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Значение функции = " + ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
