using Library;
namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = R.CreateSize(5, 10);
            int[] array = R.CreateArray(arraySize, -10, 10);
            int[] finalArray;
            R.Print(array);
            finalArray = Functions.DeleteNegative(array);
            Console.WriteLine("\nполучившийся массив:\n");
            R.Print(finalArray);
        }
    }
}