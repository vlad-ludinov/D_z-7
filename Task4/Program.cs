/*Задача 4: Напишите программу,
которая принимает на вход три числа
и выдаёт максимальное из этих чисел.*/
using static System.Console;

int a = int.Parse(ReadLine());
int b = int.Parse(ReadLine());
int c = int.Parse(ReadLine());
int max = 0;

if (a >= b && a >= c)
{
    max = a;
}
else
    if (c >= b)
    {
        max = c;
    }
    else
    {
        max = b;
    }
WriteLine($"max = {max}");