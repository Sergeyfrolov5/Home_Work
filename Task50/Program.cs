// Задача 50. 
// 1. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, 
// 2. и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Write("Введите строку матрицы: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец матрицы: ");
int column = Convert.ToInt32(Console.ReadLine());

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

void FindElements(int[,] matrix, int row1, int column1)
{
    if (row1 - 1 < matrix.GetLength(0) && column1 - 1 < matrix.GetLength(1))
    {
        int element = matrix[row1 - 1, column1 - 1];
        Console.Write($"Элемент матрицы: {row} строка {column} столбец -> {element}");
    }
    else Console.Write($"Элемент матрицы: {row} строка {column} столбец -> нет такого элемента");
}

Console.WriteLine();
int[,] createMatrixRndInt = CreateMatrixRndInt(3, 4, 10, 99);
PrintMatrix(createMatrixRndInt);
Console.WriteLine();
if (row > 0 && column > 0)
{
    FindElements(createMatrixRndInt, row, column);
}
else Console.Write("Введены некорректные данные!");
Console.WriteLine();
