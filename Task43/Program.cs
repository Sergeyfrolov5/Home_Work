// Задача 43: Напишите программу, которая 
// 1. найдёт точку пересечения двух прямых, 
// 2. заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// 3. значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] FindPointCrossing(double cb1, double ck1, double cb2, double ck2)
{
    double[] array = new double[2];
    array[0] = (cb1 - cb2) / (ck2 - ck1);
    array[1] = ck1 * (cb1 - cb2) / (ck2 - ck1) + cb1;
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("Точка пересечения двух прямых -> (");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine(")");
}

double[] findPointCrossing = FindPointCrossing(b1, k1, b2, k2);

if (k2 != k1) PrintArray(findPointCrossing);
else Console.WriteLine("Введены некорректные данные!");
