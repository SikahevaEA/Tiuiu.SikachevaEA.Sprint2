using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiuiu.SikachevaEA.Sprint2.Task4.V2.Lib;
// Написать программу, которая вычисляет требуемое значечние с использованием
// тернарного оператора, где пользователь вводит значение переменных х, у с клавиатуры,
// если x > y + 3, то
//         x + 1
// z = x + ------
//           y
// иначе
//  y + 5
// -------
//  y + 2

namespace Tiuiu.SikachevaEA.Sprint2.Task4.V2
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

            Console.WriteLine("Введите значение переменной y: ");
            double y = Convert.ToInt32(Console.ReadLine());

            double res = ds.Calculate(x, y);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();
        }
    }
}
