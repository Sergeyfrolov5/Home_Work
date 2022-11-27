// Задача 60. ...
// 1. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// 2. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateArray3D(int rows, int columns, int depth)
{
    int[,,] array3D = new int[rows, columns, depth];
    int count = 10;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = count;
                count++;
            }
        }
    }
    return array3D;
}

void PrintArray3D(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.Write("|");
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                if (k < array3D.GetLength(2) - 1) Console.Write($"{array3D[i, j, k],5} |");
                else Console.Write($"{array3D[i, j, k],5}");
            }
        }
        Console.WriteLine(" |");
    }
}

Console.WriteLine();
int[,,] createArray3D = CreateArray3D(2, 2, 2);
PrintArray3D(createArray3D);