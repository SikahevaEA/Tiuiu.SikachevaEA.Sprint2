using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tiuiu.SikachevaEA.Sprint2.Task0.V9.Lib
{
    public class DataService : ISprint2Task0V9
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x == y + 679;
            res[1] = x != y;
            res[2] = x < y + 680;
            res[3] = x > y;
            res[4] = x <= y + 680;
            res[5] = x >= y + 680;

            return res;

        }
    }
}
