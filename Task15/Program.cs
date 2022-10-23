// Задача 15: Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели: ");
int digit = Convert.ToInt32(Console.ReadLine());

if (digit > 0 && digit < 8)
{
    if (digit < 6)
    {
        Console.Write($"{digit} -> нет");
    }
    else Console.Write($"{digit} -> да");
}
else Console.Write("Введено некорректное число!");
