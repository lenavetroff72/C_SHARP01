// Напишите программу, которая на вход принимает два целых чила и проверяет, 
//является ли первое число квадратом второго.


//int first = 25;
//int second = 5;

//if(second*second == first)
//{
//    Console.Write("Yes");
//}
//else
//{
//   Console.Write("No");
//}

//Напишите программу, которая на вход принимает целое число N,
//а на выходе показывает все целые числа в промежутке от -N до N.

//int first = 5;
//int second = -first;
//
//while(second<=first)
//{
//   Console.Write(second+" ");
//    second++;
//}

//Написать программу, которая принмает на вход трехзначное чило, и на
//выходе показывает сумму первой и последней цифры этого числа.

int num = 123;
int first = num/100;
int last = num%10;
int sum = first+last;
Console.Write("Sum of first and last digit is - " + sum);