// Задача 19 Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

void Digit(int num)
{
    if (n < 100000 && n >= 10000)
    {
        int firstDigit = num / 10000;
        int seondDigit = num / 1000 % 10;
        int fourthDigit = num / 10 % 10;
        int fifthDigit = num % 10;
        if (firstDigit == fifthDigit && seondDigit == fourthDigit)
        {
            Console.WriteLine($"{num} -> да");
        }
        else Console.WriteLine($"{num} -> нет");
    }
    else System.Console.WriteLine("Введено некорректное число!");
}
Digit(n);
