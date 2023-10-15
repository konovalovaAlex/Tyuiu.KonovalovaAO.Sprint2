using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KonovalovaAO.Sprint2.Task5.V4.Lib;
namespace Tyuiu.KonovalovaAO.Sprint2.Task5.V4
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
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #4                                                             *");
            Console.WriteLine("* выполнила: Коновалова Александра Олеговна | СМАРТб-23-1                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет       *");
            Console.WriteLine("* требуемое значение и возвращает результат.                             *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int value;
            Console.WriteLine("Введите номер масти от 1 до 4: ");
            value = Convert.ToInt32(Console.ReadLine());
            string res;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Резльтат                                                                *");
            Console.WriteLine("***************************************************************************");

            if (value > 4 || value < 1)
            {
                res = "Такой масти нет!";
            }
            else
            {
                res = "Ваша масть : " + ds.FindCardSuit(value);
            }
            Console.WriteLine(res);

            Console.ReadKey();





        }
    }
}
