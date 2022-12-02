using Library;
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = Functions.CreateArray(3, -9, 9);
            Console.WriteLine(" массив:");
            Functions.Print(array);
            Functions.ReplacePositive(array);
            Console.WriteLine("Вид массива после изменений:");
            Functions.Print(array);
        }
    }
}