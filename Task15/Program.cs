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



// 17. Напишите программу, которая 
// 1. принимает на вход координаты точки (X и Y), 
// 2. причём X ≠ 0 и Y ≠ 0 и 
// 3. выдаёт номер четверти плоскости, в которой находится эта
// точка.

Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int xc, int yc)
{
if (xc > 0 && yc > 0) return 1;
if (xc < 0 && yc > 0) return 2;
if (xc < 0 && yc < 0) return 3;
if (xc > 0 && yc < 0) return 4;
return 0;
}
int quarter = Quarter(x, y);