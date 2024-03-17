//Задание 1. Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

//char[,] array = new char[,]
//{
//    {'a', 'b', 'c'},
//    {'d', 'e', 'f'},
//    {'g', 'h', 'i'}
//};

//string result = string.Empty;

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        result += array[i, j];
//    }
//}

//Console.WriteLine(result);

//Задание 2. Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.

//string inputString = "aBcD1ef!-";
//string convertedString = inputString.ToLower();
//Console.Write(convertedString);

//Задание 3. Задайте произвольную строку. Выясните, является ли она палиндромом.

string str = Console.ReadLine();
string reverseStr = "";
for (int i = str.Length - 1; i >= 0; i--)
{
    reverseStr += str[i];
}
if (str == reverseStr)
{
    Console.WriteLine("Введенная строка является палиндромом.");
}
else
{
    Console.WriteLine("Введенная строка не является палиндромом.");
}

Console.ReadKey();

