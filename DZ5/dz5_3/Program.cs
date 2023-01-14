// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размерность массива");
int N = Convert.ToInt32(Console.ReadLine());
double[] array = new double[N];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Минимальное число {MinValArray(array)}");
Console.WriteLine($"Миксимальное число {MaxValArray(array)}");
Console.WriteLine($"Разница {Math.Round(MaxValArray(array) - MinValArray(array), 2)}");

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = Math.Round(new Random().NextDouble(), 2) + new Random().Next(0, 100);
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

double MinValArray(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double MaxValArray(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}