/*Задача 2: Напишите программу,
которая на вход принимает два числа
и выдаёт, какое число большее,
а какое меньшее.*/
using static System.Console;

int a = int.Parse(ReadLine()!);
int b = int.Parse(ReadLine()!);
int max = 0;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}
WriteLine($"max = {max}");