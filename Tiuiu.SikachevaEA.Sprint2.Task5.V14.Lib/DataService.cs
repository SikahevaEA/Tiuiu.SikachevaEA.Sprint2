using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tiuiu.SikachevaEA.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
            if ((k < 1) || (k > 365))
            {
                throw new ArgumentException("День в году находится находится в промежутке от 1 до 365");
            }
            if ((d < 1) && (d > 7))
            {
                throw new ArgumentException("День недели находится в прмежутке от 1 до 7");
            }

            int day = k % 7;

            switch (day)
            {
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                case 0: return "Воскресенье";
            }
            return "Что-то не так";
        }
    }
}
