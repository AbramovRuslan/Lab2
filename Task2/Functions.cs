using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Functions
    {
        public static int[,,] CreateArray(int arraySize, int begin, int end)
        {
            Random rand = new Random();

            int[,,] array = new int[arraySize, arraySize, arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    for (int k = 0; k < arraySize; k++)
                    {
                        array[i, j, k] = rand.Next(begin, end);
                    }
                }
            }
            return array;
        }
        public static void Print(int[,,] array)
        {
            for (int z = 0; z < array.GetLength(0); z++)
            {
                Console.WriteLine("{0} слой:", z + 1);
                for (int y = 0; y < array.GetLength(0); y++)
                {
                    for (int x = 0; x < array.GetLength(0); x++)
                    {
                        Console.Write("{0}\t", array[x, y, z]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        public static void ReplacePositive(int[,,] array)
        {
            for (int z = 0; z < array.GetLength(0); z++)
              {
                for (int y = 0; y < array.GetLength(0); y++)
                { 
                    for (int x = 0; x < array.GetLength(0); x++)
                    {
                       if (array[x, y, z] > 0)
                       {
                           array[x, y, z] = 0;
                       }
                    }
                }
            }
        }
    }
 }
