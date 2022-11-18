// Задача 41: 
// 1. Пользователь вводит с клавиатуры M чисел. 
// 2. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Введите числа массива через Enter:");
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int FindPositiveElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int[] createArray = CreateArray(num);
PrintArray(createArray);

int findPositiveElements = FindPositiveElements(createArray);
Console.WriteLine($"Количество чисел больше 0: -> {findPositiveElements}");