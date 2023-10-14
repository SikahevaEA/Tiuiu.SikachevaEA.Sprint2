using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiuiu.SikachevaEA.Sprint2.Task3.V19.Lib;
//Написать программу, которая вычисляет требуемое значение функции Y с
//использованием вложенных оператор if-else, где пользователь вводит значение
//переменной X с клавиатуры. Округлить полученное значение до трех знаков после
//запятой;
//    |       ((x + 1))^x
//    | x^2 + (-------)   , если x > 1
//    |       ((x - 1))
//    |
//    | (x^2 + Cos^2(x) + 13)
//    | --------------------- , если x = 0
//    | (x^2 + Sin^2(x) + 9)
//y= -|
//    | (     1 )^x
//    | (1 + ---)  , если -23 < x < 2
//    | (    x^2)
//    |
//    |           ( 1 )
//    | x + 10x + (---)  , если x < -23
//    |           ( x )

namespace Tiuiu.SikachevaEA.Sprint2.Task3.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите значение переменной х: ");
            double x = Convert.ToInt32(Console.ReadLine());
            double res = Math.Round(ds.Calculate(x), 3);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();
        }
    }
}
