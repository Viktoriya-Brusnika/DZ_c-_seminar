// задача 2 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
// Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, найти максимальное число и его индекс. 
// Вывести эту информацию на экран.

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] Ar = new int[m, n];
FillTwoArray(Ar);
PrintArray(Ar);
MaxValArray(Ar);
MinValArray(Ar);


void FillTwoArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(0, 100);
    }
  
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0;j < array.GetLength(1);j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MinValArray(int[,] array)
{
    int min = array[0, 0];
    int index1 = 0;
    int index2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min) 
            {
                min = array[i, j]; 
                index1 = i;
                index2 = j;
            }

        }
    }
    Console.WriteLine($"Минимальное значение = {min}, его индекс [{index1},{index2}]");
}

void MaxValArray(int[,] array)
{
    int max = array[0, 0];
    int index1 = 0;
    int index2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > max) 
            {
                max = array[i, j];
                index1 = i;
                index2 = j;
            }
        }
    }
    Console.WriteLine($"Максимальное значение = {max}, его индекс [{index1},{index2}]");
}