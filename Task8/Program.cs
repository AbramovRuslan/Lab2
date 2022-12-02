using Library;
namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива:");
            int arraySize = R.IntTryParse();
            if (arraySize < 1)
            {
                Console.WriteLine("Вы ввели размерность массива равную или меньше 0, пожалуйста, попробуйте снова");
                return;
            }
            int[] array = R.CreateArray(arraySize, 0, 10);
            R.Print(array);
            int number = Functions.CheckingInt();
            int[] arrOfIndex = Functions.CreatingIndexArray(array, number);
            if (arrOfIndex.Length == 0)
            {
                Console.WriteLine("элементы не найдены");
            }
            else
            {
                R.Print(arrOfIndex);
            }
            
        }
    }
}