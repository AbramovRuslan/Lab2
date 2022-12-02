using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Functions
    {
        public static int[] CreatingIndexArray(int[] arr, int value)
        {
            int ammount = 0;
            int index = 0;
            int[] arrayOfIndex = new int[arr.Length];
            while (Array.IndexOf(arr, value, index) != -1) 
            {
                arrayOfIndex[ammount] = Array.IndexOf(arr, value, index);
                index = arrayOfIndex[ammount] + 1;
                ammount++;
            }
            Array.Resize(ref arrayOfIndex, ammount);
            return arrayOfIndex;
        }

        public static int CheckingInt()
        {
            int number;
            Console.Write("\n Введите искомое число : ");
            bool check = int.TryParse(Console.ReadLine(), out number);
            while (!check)
            {
                Console.Write("Неверное значение, попробуйте снова ");
                check = int.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }
    }
}
