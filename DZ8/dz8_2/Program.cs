// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[rows,cols ];
FillArray(array);
PrintArray(array);
Console.WriteLine();
PrintArray2(RowsSumm(array));
Console.WriteLine($"Строка с наименьшей суммой элементов: {MinElemetArray(RowsSumm(array))}");





void FillArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(-10,11);
}

void PrintArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],3} \t");
        Console.WriteLine();
    }
}

 int[] RowsSumm(int[,] array)
{
   int[] summarray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ += array[i,j];
        }
        summarray[i] = summ;

    }
    return summarray;
}

void PrintArray2(int [] mas)
{
    for (int i=0;i<mas.Length; i++)
        Console.Write($"{mas[i]} ");
    Console.WriteLine();
}


int MinElemetArray(int [] array)
{
    int min = array[0];
    int n = 0;
    for (int i = 1; i < array.Length; i++)
{
    if (min > array[i]) 
    {
        min = array[i];
        n = i+1;
    }
}
    return n;
}