// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] Ar = new int[rows, cols];
FillTwoArray(Ar);
PrintArray(Ar);
Console.WriteLine(ArithmMeanCols(Ar));


void FillTwoArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(0, 10);
    }

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

string ArithmMeanCols(int[,] array)
{
    string A = "Среднее арифметическое каждого столбца: ";
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double summ = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
           summ+=array[j,i];
        }
        A+=$"{summ/array.GetLength(0):f1}; ";
    }
    return A;

}