using Library;
namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите вариант решения:" +
                "\n1)Рандомное заполнение массивов" +
                "\n2)Гарантированно равные массивы"+
                "\n3)Ввод размера и заполнение массива");
            int Answer = R.IntTryParse();
            switch (Answer)
            {
                case 1:
                    int arraySize = R.CreateSize(5, 10);
                    int[] arrayOne = R.CreateArray(arraySize, 0, 100);
                    int[] arrayTwo = R.CreateArray(arraySize, 0, 100);
                    Console.WriteLine("Массив 1: ");
                    R.Print(arrayOne);
                    Console.WriteLine("\n Массив 2: ");
                    R.Print(arrayTwo);
                    if (Functions.Code(arrayOne, arrayTwo))
                    {
                        Console.WriteLine("\n Массивы равны");
                        return;
                    }
                    Console.WriteLine("\n Массивы не равны");
                    break;
                case 2:
                    {
                        int[] arrayOneTrue = new int[5] { 1, 10, 15, 4, 3 };
                        int[] arrayTwoTrue = new int[6] { 10, 15, 1, 3, 4, 70 };
                        Console.WriteLine("Массив 1: ");
                        R.Print(arrayOneTrue);
                        Console.WriteLine("\nМассив 2: ");
                        R.Print(arrayTwoTrue);
                        if (Functions.Code(arrayOneTrue, arrayTwoTrue))
                        {
                            Console.WriteLine("\n Массивы равны");
                            return;
                        }
                        Console.WriteLine("\n Массивы не равны");
                        break;
                    }
                case 3:
                    Console.WriteLine("\n введите размерномть массива");
                    int Size = R.IntTryParse();
                    int[] array1= new int[Size];
                    int[] array2= new int[Size];
                    Console.WriteLine("\n заполнение первого массива");
                    for (int i = 0; i < Size; i++)
                    {
                        Console.WriteLine("\n введите {0} число:", i + 1);
                        int value = R.IntTryParse();
                        array1[i] = value;
                    }
                    R.Print(array1);
                    Console.WriteLine("\n заполнение второго массива");
                    for (int i = 0; i < Size; i++)
                    {
                        Console.WriteLine("введите {0} число:", i + 1);
                        int value = R.IntTryParse();
                        array2[i] = value;
                    }
                    R.Print(array2);
                    if (Functions.Code(array1, array2))
                    {
                        Console.WriteLine("\n Массивы равны");
                        return;
                    }
                    Console.WriteLine("\n Массивы не равны");
                    break;
                default:
                    Console.WriteLine("Введите корректное значение и повторите снова!");
                    break;
            }
        }
    }
}