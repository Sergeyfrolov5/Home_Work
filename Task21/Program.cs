// Задача 21. Напишите программу, которая 
// 1. принимает на вход координаты двух точек и 
// 2. находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A: ");
Console.Write("AX: ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.Write("AY: ");
int aY = Convert.ToInt32(Console.ReadLine());
Console.Write("AZ: ");
int aZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("BX: ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.Write("BY: ");
int bY = Convert.ToInt32(Console.ReadLine());
Console.Write("BZ: ");
int bZ = Convert.ToInt32(Console.ReadLine());

double Vector(double aX1, double aY1, double aZ1, 
double bX1, double bY1, double bZ1)
{
    double kat1 = aX1 - bX1;
    double kat2 = aY1 - bY1;
    double kat3 = aZ1 - bZ1;
    double res2 = kat1 * kat1 + kat2 * kat2 + kat3 * kat3;
    double res = Math.Sqrt(res2);
    double result = Math.Round(res, 2, MidpointRounding.ToZero);
    return result;
}

double vector = Vector(aX, aY, aZ, bX, bY, bZ);
Console.WriteLine($"A ({aX}, {aY}, {aZ}); B ({bX}, {bY}, {bZ}) -> {vector}");

