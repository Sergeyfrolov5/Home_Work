// Задача 56: 
// 1. Задайте прямоугольный двумерный массив. Напишите программу, 
// 2. которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

int[] CreateArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        array[count] = default;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count] += matrix[i, j];
        }
        count++;
    }
    return array;
}

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.WriteLine("]");
// }

int FindMinRow(int[] array)
{
    int i = 0;
    int min = array[i];
    for (i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    int indexMin = Array.IndexOf(array, min);
    return indexMin + 1;
}

Console.WriteLine();
int[,] createMatrixRndInt = CreateMatrixRndInt(3, 4, 10, 99);
PrintMatrix(createMatrixRndInt);
Console.WriteLine();
int[] createArray = CreateArray(createMatrixRndInt);
// PrintArray(createArray);
int findMinRow = FindMinRow(createArray);
Console.WriteLine($"Строка с наименьшей суммой элементов -> {findMinRow}");

