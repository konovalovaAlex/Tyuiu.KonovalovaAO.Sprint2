using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KonovalovaAO.Sprint2.Task0.V3.Lib
{
    public class DataService : ISprint2Task0V3
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] rez = new bool[6];
            rez[0] = x == y; 
            rez[1] = x != y; 
            rez[2] = x < y - 100 ; 
            rez[3] = x + 100 > y;  
            rez[4] = x <= y - 100; 
            rez[5] = x + 100 >= y; 
            return rez;
        }
    }
}
