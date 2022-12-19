/*Задача 6: Напишите программу,
которая на вход принимает число
и выдаёт, является ли число чётным
(делится ли оно на два без остатка).*/
using static System.Console;

int number = int.Parse(ReadLine());

if (number % 2 == 0)
{
    WriteLine("Чётное");
}
else
{
    WriteLine("Нечётное");
}