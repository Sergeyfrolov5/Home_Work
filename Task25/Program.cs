// Задача 25: Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Degree(int numA, int numB)
{
    if (numB > 0)
    {
        int count = 0;
        int numberC = 1;
        while(count < numB)
        {
            numberC = numberC * numA;
            count++;
        }
        return numberC;
    }
    else return -1;
}

int degree = Degree(numberA, numberB);
Console.WriteLine($"{numberA} в {numberB} степени -> {degree}");