// int x = 1234;
// int a1 = x % 10;
// int a2 = x / 10 % 10;
// int a3 = x / 100 % 10;
// int a4 = x / 1000;
// x = a1 * 1000 + a2 * 100 + a3 * 10 + a4;
// Console.Write(x == 1);



double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(array[i], 1, MidpointRounding.ToZero);

    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double[] createArrayRndDouble = CreateArrayRndDouble(5, 10, 20);
PrintArray(createArrayRndDouble);
