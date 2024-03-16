//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//Указание: использовать рекурсию.
//Пример: 123 => 6     63 => 9

//int SumOfDigits(int num)
//{
//    if(num == 0)
//    {
//        return 0;
//    }
//    int sum = num%10 + SumOfDigits(num/10);
//    return sum;
//}

//Console.Write(SumOfDigits(222));

//Задать значение N. Написать программу, которая выведет все натуральные числа в промежутке от 1 до N.
//Указание: использовать рекурсию. 
//Пример: N=5 => 1 2 3 4 5

//void PrintNumbers(int n)
//{
//    if (n == 0)
//    {
//        return;
//    }
//    PrintNumbers(n - 1);
//    Console.Write(n);
//    Console.Write(" ");
//}

//PrintNumbers(5);

//Считать строку из консоли, содержащую только латинские буквы.
//Вывести на экран согласные буквы этой строки.
//Указание: использоваеть рекурсию

//void GetConsonant(string str)
//{
//    if (str.Length == 0)
//    {
//        return;
//    }
//    string vowels = "aeuoi";
//    if (char.IsLetter(str[0]) && !vowels.Contains(char.ToLower(str[0])))
//    {
//        Console.Write($"{str[0]} ");
//    }    GetConsonant(str.Substring(1));
//
//Console.WriteLine("Введите строку: ");
//string str = Console.ReadLine();
//GetConsonant(str);