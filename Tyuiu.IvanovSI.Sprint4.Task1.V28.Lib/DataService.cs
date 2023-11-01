using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.IvanovSI.Sprint4.Task1.V28.Lib
{
    public class DataService : ISprint4Task1V28
    {
        public int Calculate(int[] array)
        {
            int pr = 1;
            foreach (int i in array)
            {
                if (i % 2 !=0)
                {
                    pr *= i;
                }
            }
            return pr;
        }
    }
}
