// Задача 8: Напишите программу, которая 
// 1. на вход принимает число (N), а 
// 2. на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 2;

if (n > 0)
{
    Console.Write($"Чётные числа от 1 до {n}: ");
    while (count <= n)
    {
        if (count % 2 == 0)
            Console.Write($"{count} ");
    count++;
    }
}
else Console.Write("Введено некорректное число!");










// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int count = 2;
// if (n > 0)
// {
//     Console.WriteLine($"Чётные числа от 1 до {n}:");
//     while (count <= n)
//     {
//         if (count % 2 == 0)
//         {
//             Console.WriteLine($"{count}");
//         }
//         count++;
//     }
// }
// else Console.WriteLine("Введите другое число!");





// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int count = 2;
// if (n <= 0)
// {
//     Console.WriteLine("Введите другое число!");
// }
// else
// {
//     Console.WriteLine($"Чётные числа от 1 до {n}:");
//     while (count <= n)
//     {
//         if (count % 2 == 0)
//         {
//             Console.WriteLine($"{count}");
//         }
//         count++;
//     }
// }