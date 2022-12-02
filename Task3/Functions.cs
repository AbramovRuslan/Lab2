using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Functions
    {
        public static int SumPositive(int[] array)
        {
            int sumPositive = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sumPositive += array[i];
                }
            }
            return sumPositive;
        }
    }
    
}
