using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LyaginVA.Sprint2.Task1.V3.Lib
{
    public class DataService : ISprint2Task1V3
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a < b) | (a > b);
            res[1] = (c == d) & (c > b);
            res[2] = (c > d) || (a == b);
            res[3] = (b > a) && (a < c);
            res[4] = (!res[0]);
            res[5] = (c == d) ^ (a < b);

            return res;
        }
    }
}
