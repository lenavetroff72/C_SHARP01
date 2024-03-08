int[] CreateRandomArray(int min, int max, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    foreach(int item in array)
    {
        Console.Write(item+" ");
    }
    Console.WriteLine();
}

//int CountOfPrimes(int[] array)
//{
//    int count = 0;
//   foreach(int el in array)
//    {
//       if(IsPrime(el)) 
//       {
//            count++;
//       }
//    }
//    return count;
//}

//bool IsPrime(int num)
//{
//    double limit = Math.Sqrt(num);
//    for(int i = 2; i <= limit; i++)
//    {
//        if(num%i == 0)
//        {
//            return false;
//        }
//    }
//    return true;
//}

int CountOfDefs(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    { 
        if(DefToSeven(array[i]))
        {
            count++;
        }
        
    }
    return count;
}

bool DefToSeven(int num)
{
    if(num%10 == 1 && num%7 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Clear();
Console.WriteLine("Введите минимальное число в массиве:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массиве:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите рвзмер массива:");
int size = Convert.ToInt32(Console.ReadLine());


//Задайте одномерный массив, заполненный случайными числами
//Определите количество простых чисел в этом массиве.
//Примеры
//[1 3 4 19 3] => 2
//[4 3 4 1 9 5 21 13] => 3


int[] array = CreateRandomArray(min, max, size);
ShowArray(array);
//int count = CountOfPrimes(array);
//Console.WriteLine($"Количество простых чисел в массиве равно - {count}");

//Найдите количество чисел, которые заканчиваются на 1 и делятся на 7 без остатка.
//Пример
//[1 5 11 21 81 4 0 91 2 3] 
//=> 2

int count = CountOfDefs(array);
Console.WriteLine($"Количество чисел равно - {count}");
