using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiuiu.SikachevaEA.Sprint2.Task5.V14.Lib;
//Написать программу, которая использует оператор switch вычисляет требуемое значение и возвращает результат.
//Дано целое число k (1 <= k <= 365). Определить, каким днем недели
//(понедельником, вторником, …, субботой или воскресеньем) является k-й день не високосного года,
//в котором 1 января d-й день недели (если 1 января — понедельник,
//то d = 1 , если вторник — d = 2 , …, если воскресенье — d = 7).

namespace Tiuiu.SikachevaEA.Sprint2.Task5.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите номер дня в году: ");
            int numDayinYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер дня недели: ");
            int numDayofWeek = Convert.ToInt32(Console.ReadLine());

            string res;

            res = "Днём недели является " + ds.FindDayName(numDayinYear, numDayofWeek);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
