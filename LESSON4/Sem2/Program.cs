//Задайте массив символов (тип char[]). Создайте строку из символов этого массива.
//Указание: конструктор строки вида string(char[]) не использовать.

//string GetStringFromArrayChars(char[] chars)
//{
//    string str = string.Empty;
//    foreach (char item in chars)
//    {
//        str += item;
//    }
//    return str;
//}

//char[] chars = { 'H', 'e', 'l', 'l', 'o' };
//string str = GetStringFromArrayChars(chars);
//Console.WriteLine(str);

//На основе символов строки создать массив символов и вывести массив на экран.

//char GetArrayFromStringChars(string str)
//{
//    char[] chars = new char[str.Length];
//    for (int i = 0; i < str.Length; i++)
//    {
//        chars[i] = str[i];
//    }
//    return chars;
//}

//string str = "Hello";
//char[] array = GetArrayFromStringChars(str);
//foreach (char item in array)
//{
//    Console.WriteLine(item);
//}

//Считать строку с консоли, состоящую из латинских букв в нижнем регистре. 
//Выяснить, сколько среди введённых букв гласные.

int CountVowels(string str)
{
    int count = 0;
    string vowels = "aouei";
    foreach (char c in str.ToLower())
    {
        if (vowels.Contains(c))
        {
            count++;
        }
    }
    return count;
}

string str = "Ask no question";
int count = CountVowels(str);
Console.Write(count);