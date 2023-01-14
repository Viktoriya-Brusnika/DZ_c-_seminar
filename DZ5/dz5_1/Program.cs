// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int[5];
FillArray(array);
PrintArray(array);
Console.WriteLine(NumbEven(array));

void PrintArray(int [] array)
{
    for (int i=0;i<array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}


void FillArray(int[] array)
{
    int N = array.Length;
    for (int i = 0; i < N; i++) array[i] = new Random().Next(100, 1000);
}

int NumbEven(int[] array)
{
    int N = array.Length;
    int count = 0; 
    for (int i = 0; i < N; i++)
    {
        if (array[i] %2 == 0) 
        count = count + 1;
    }
    return count;
}