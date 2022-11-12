// Задача 27: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigit(int num)
{
    int digit = default;
    num = Math.Abs(num);
    while(num != 0)
    {
        digit = digit + num % 10;
        num = num / 10;
    }
    return digit;
}

int sumDigit = SumDigit(number);
Console.Write($"Сумма цифр числа -> {sumDigit}");





