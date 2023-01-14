// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размерность массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма четных элементов {EvenElementSum(array)}");

void FillArray(int[] array)
{
    int N = array.Length;
    for (int i = 0; i < N; i++) array[i] = new Random().Next(0, 100);
}

void PrintArray(int [] array)
{
    for (int i=0;i<array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int EvenElementSum(int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i=i+2) sum = sum + array[i];
    return sum;
}