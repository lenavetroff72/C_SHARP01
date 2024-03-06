//Задача 1. Напишите программу, которая на вход принимает два числа,
//и выдает какое число большее, а какое меньшее.

int firstNumber = 12;
int secondNumber = 10;

if (firstNumber > secondNumber)
{
    Console.WriteLine("первое чиcло больше");    
}
else if (secondNumber > firstNumber)
{
    Console.WriteLine("второе число больше");
}
else
{
    Console.WriteLine("числа равны");
}