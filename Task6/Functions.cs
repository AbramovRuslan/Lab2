using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Functions
    {
        public static int[] Duplicate(int[] array)
        {
            int[] finalArray;
            int finalsize;
            int arraySize = array.Length;
            int value = 0;
            for (int i = 0; i < arraySize; i++)
            {
                if (array[i] < 0)
                {
                    value++;
                }
            }
            finalsize = arraySize + value;
            finalArray = new int[finalsize];
            int n = 0;
            for (int i = 0; i < arraySize; i++)
            {
                if (array[i] >= 0)
                {
                    finalArray[n] = array[i];
                    n++;
                }
                if (array[i] < 0)
                {
                    finalArray[n] = array[i];
                    n++;
                    finalArray[n] = array[i];
                    n++;
                }

            }
            return finalArray;
        }
    }
}
