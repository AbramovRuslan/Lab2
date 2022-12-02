using Library;
namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = R.CreateSize(5, 10);
            int[,] array = Functions.CreateArray(arraySize, 1, 10);
            Functions.Print(array);
            int Sum = Functions.SumEvenPositions(array);
            Console.WriteLine("\n Сумма элементов на четных позициях = {0}", Sum);
        }
    }
}