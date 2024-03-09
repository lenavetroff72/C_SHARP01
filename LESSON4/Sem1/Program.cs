int[,] Create2dArray(int min, int max, int rows, int cols)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Show1dArray(int[] array)
{
    foreach (int item in array).
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

int[] Create1dArray(int [,] array)
{
    int[,] array2 = new int[GetLength(0), GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        array2[i] = sum / array.GetLength(1);
    }
    return array2;
}

Console.Write("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter min value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter min value: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter min value: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = Create2dArray(min, max, rows, cols);
Show2dArray(array);

//Задать 2-мерный массив. Найти элементы, у которых оба индекса четные, и заменить их на их квадраты.

//int[,] CheckEvenIndex(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            if (i % 2 == 0 && j % 2 == 0)
//            {
//                array[i, j] *= array[i, j];
//            }
//        }
//    }
//    return array;
//}
//Console.WriteLine();
//int[,] array2 = CheckEvenIndex(array);
//Show2dArray(array2);

//Задать 2-мерный массив. Найти сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1,1) и т.д.)
//Пример: 2 3 4 3
//        4 3 4 1 => 2 + 3 + 5 = 10
//        2 9 5 4  

//int[,] SumMainDiaonal(int[,] array)
//{
//    int sum = 0;
//    for (int i = 0; i < rows; i++)
//    {
//        for (int j = 0; j < cols; j++)
//        {
//            if(i == j)
//            {
//                sum += array[i, j];
//            }
//        }
//        return sum;
//    }
//}
//Console.WriteLine();
//int sum = SumMainDiaonal(array);
//Console.Write(sum);

//Задать 2-мерный массив из целых чисел. Сформировать новый одномерный массивЮ состоящий
//из средних арифметических значений по строкам 2-мерного массива.

Console.WriteLine();
int [] array1d - Create2dArray (array);
Show1dArray(array1d);
    