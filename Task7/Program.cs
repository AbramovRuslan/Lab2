using Library;
namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива:");
            int arraySize = R.IntTryParse();
           
            int[] array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine("введите {0} число:", i + 1);
                int value = R.IntTryParse();
                array[i] = value;
            }
            R.Print(array);
            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine("\nОтсортированный массив:");
            R.Print(array);
        }
    }
}