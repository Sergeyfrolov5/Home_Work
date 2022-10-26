// Задача 23. Напишите программу, которая 
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125


Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

void Cube(int nA)
{
    if (nA > 0)
    {
        Console.WriteLine($"{nA} -> ");
        while (count <= nA)
        {
            int cube = Convert.ToInt32(Math.Pow(count, 3));
            Console.WriteLine($"|{count, 4}|{cube, 4}|");
            count++;
        }
    }
    else Console.WriteLine("Введено некорректное число!");
}

Cube(n);




// Console.Write("Введите целое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int count = 1;

// int Cube(int nA)
// {
//     if (nA > 0)
//     {
//         Console.WriteLine($"{nA} -> ");
//         while (count <= nA)
//         {
//             int cube = Convert.ToInt32(Math.Pow(count, 3));
//             Console.WriteLine($"|{count,4}|{cube,4}|");
//             count++;
//         }
//     }
//     else Console.Write("Введено некорректное число!");
// }

// int result = Cube(n);
