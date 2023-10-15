using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiuiu.SikachevaEA.Sprint2.Task6.V3.Lib;
//Написать программу, которая использует сокращенную форму записи оператора switch
//вычисляет требуемое значение и возвращает результат.
//Условие: Составить программу, которая в зависимости от порядкового номера дня недели (1, 2, …, 7)
//выводит на экран его название (понедельник, вторник, …, воскресенье). 

namespace Tiuiu.SikachevaEA.Sprint2.Task6.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите номер дня: ");
            int numDay = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numDay < 1) || (numDay > 7))
            {
                res = "Введено не правильное значение";
            }
            else
            {
                res = "Название дня: " + ds.FindDayName(numDay);
            }

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
