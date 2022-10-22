// Задача 10: Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа. 
// 3. Выполнить с помощью числовых операций (целочисленное деление,
// остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трёхзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99 && number < 1000)
// {
//     int div = number / 10;
//     int secondDigit = div % 10;
//     Console.WriteLine($"Вторая цифра числа {number} -> {secondDigit}");
// }
// else Console.WriteLine("Введите трёхзначное число!");




Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int FindSecondDigit(int num)
{
    if (num > 99 && num < 1000)
    {
        int div = num / 10;
        return div % 10;
    }
    return -1;
}

int res = FindSecondDigit(number);
Console.WriteLine($"Вторая цифра числа {number} -> {res}");

