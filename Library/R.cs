namespace Library
{
    public static class R
    {
        public static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}\t", array[i]);
            }
        }
        public static int[] CreateArray(int arraySize, int begin, int end)
        {
            Random rand = new Random();
            int[] array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = rand.Next(begin, end);
            }
            return array;
        }
        public static int CreateSize(int begin, int end)
        {
            Random rand = new Random();
            int arraySize = rand.Next(begin, end);
            return arraySize;
        }
        public static int IntTryParse()
        {
            int result = 0;
            bool tr = true;
            while (tr)
            {
                bool successful = int.TryParse(Console.ReadLine(), out result);
                if (!successful)
                {
                    Console.WriteLine("Введите число!\nПопробуйте снова:");
                }
                else
                {
                    if (result < 0)
                    {
                        Console.WriteLine("Вы ввели отрицательное значение, пожалуйста, введите положительное значение!");
                    }
                    else
                    {
                        tr = false;
                    }
                }
            }
            return result;
        }

    }
}