﻿// Задача 64: 
// 1. Задайте значение N. 
// 2. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int num)
{
    if (num == 0) return;
    if (num != 1) Console.Write($"{num}, ");
    else Console.Write($"{num}");
    NaturalNumbers(num - 1);
}

if (number > 0) NaturalNumbers(number);
else Console.WriteLine("Введено некорректное число!");