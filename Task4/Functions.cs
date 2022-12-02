using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Functions
    {
        public static int SumEvenPositions(int[,] array)
        {
            int sum = 0;
            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(0); y++)
                {
                    if ((x + y) % 2 == 0)
                    {
                        sum += array[x, y];
                    }
                }
            }
            return sum;
        
        }
        public static int[,] CreateArray(int arraySize, int begin, int end)
        {
            Random rand = new Random();
            int[,] array = new int[arraySize, arraySize];
            for (int x = 0; x < arraySize; x++)
                for (int y = 0; y < arraySize; y++)
                {
                    array[x, y] = rand.Next(begin, end);
                }
            return array;
        }
        public static void Print(int[,] array)
        {
            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(0); y++)
                {
                    Console.Write("{0}\t", array[x, y]);
                }
                Console.WriteLine();
            }
        }

    }
}
