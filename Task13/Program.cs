// Задача 13: Напишите программу, которая 
// 1. выводит третью цифру заданного числа или 
// 2. сообщает, что третьей цифры нет. 
// 3. Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"третья цифра числа {number} -> ");

if (number >= 1000)
{
    while (number >= 1000)
    {
        number = number / 10;
        if (number < 1000)
        {
            Console.Write($"{number % 10}");
        }
    }
}
else if (number > 99 && number < 1000)
{
int thirdDigit = number % 10;
Console.Write($"{thirdDigit}");
}
else Console.Write("нет");
