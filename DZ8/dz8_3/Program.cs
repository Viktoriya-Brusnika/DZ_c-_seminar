// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк первой матрицы");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы и число строк второй таблицы");
int cols1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы");
int cols2 = Convert.ToInt32(Console.ReadLine());
int[,] ar1 = new int[rows1, cols1];
int[,] ar2 = new int[cols1, cols2];
FillArray(ar1);
FillArray(ar2);
PrintArray(ar1);
Console.WriteLine("----------");
PrintArray(ar2);
Console.WriteLine("Их произведение:");
PrintArray(ProdArray(ar1,ar2));


void FillArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(0,10);
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

int[,] ProdArray(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int k = 0; k < array1.GetLength(1); k++)
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                array3[i,j] += array1[i,k] * array2[k,j];
            }
        
        }
    }

    return array3;
}