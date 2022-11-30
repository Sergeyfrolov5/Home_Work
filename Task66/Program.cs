// Задача 66: 
// 1. Задайте значения M и N. 
// 2. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int FindSumElements(int numM, int numN)
{
    int sum = default;
    if (numM <= numN) sum = numN + FindSumElements(numM, numN - 1);
    return sum;
}

if (numberM <= numberN)
{
    int findSumElements = FindSumElements(numberM, numberN);
    Console.Write("Сумма натуральных элементов в промежутке ");
    Console.WriteLine($"от {numberM} до {numberN} -> {findSumElements}");
}
else
{
    int findSumElements = FindSumElements(numberN, numberM);
    Console.Write("Сумма натуральных элементов в промежутке ");
    Console.WriteLine($"от {numberM} до {numberN} -> {findSumElements}");
}




// while (numM < 0)
// {
//     Console.WriteLine($"Введено отрицательное число!");
//     Console.Write("Введите натуральное число M: ");
//     numM = Convert.ToInt32(Console.ReadLine());
// }