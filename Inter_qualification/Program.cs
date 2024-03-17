//Задание 1. Задайте значения M и N. Напишите программу, которая выведет все
//натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
//Пример: М = 1; N = 5 -> "1, 2, 3, 4 ,5"
//        M = 4; N = 8 -> "4, 5, 6, 7, 8"

//int UserNumber(string message)
//{
//    Console.WriteLine(message);
//    int num = Convert.ToInt32(Console.ReadLine());
//    return num;
//}

//void PrintNaturalNumbers(int m, int n)
//{
//    if (m > n)
//    {
//        PrintNaturalNumbers(m, n + 1);
//        Console.Write($"{n} ");
//    }
//    else if (m < n)
//    {
//        PrintNaturalNumbers(m, n - 1);
//        Console.Write($"{n} ");
//    }
//    else Console.Write($"{n} ");
//}

//int m = UserNumber("Enter digit m: ");
//int n = UserNumber("Enter digit n: "); 
//PrintNaturalNumbers(m, n);

//Задание 2. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n. 
//Пример: m = 2, n = 3 -> A(m,n) = 29

//Console.Write("Enter digit m: ");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter digit n: ");
//int n = Convert.ToInt32(Console.ReadLine());

//int A(int m, int n)
//{
//    if (m == 0)
//    {
//         return n + 1;
//    }
//    else
//    {
//        if (n == 0)
//        {
//            return A(m - 1, 1);
//        }
//        else
//        {
//            return A(m - 1, A(m, n - 1));
//        }
//    }    
//}

//Console.WriteLine($" = {A(m,n)} ");


//Задайте произвольный массив. Выведите его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.
//Пример: [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 


int[] CreateArrRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void PrintOut(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[^1]}");
}


void ReverseArray(int[] arr)
{

    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = temp;
    }
}

int[] array = CreateArrRndInt(6, 0, 99);
PrintOut(array);
Console.WriteLine();
ReverseArray(array);
PrintOut(array);