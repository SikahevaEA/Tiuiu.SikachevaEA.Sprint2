using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiuiu.SikachevaEA.Sprint2.Task1.V30.Lib;
//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать,
//но использовать один раз в выражении) и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), 
//а также арифметических выражений, которая вернет логическую последовательность(массив):
//(True, False, True, True, True, False), при a = 657, b = 874, c = 14, d = 654

namespace Tiuiu.SikachevaEA.Sprint2.Task1.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 657;
            int b = 874;
            int c = 14;
            int d = 654;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
