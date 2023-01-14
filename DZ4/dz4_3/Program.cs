// Задача 29: Напишите программу, которая задаёт массив из 8 целых 
// чисел с клавиатуры и далее выводит массив на экран в одну строку.


int[] array = new int[8];
InputNumb(8, array);
PrintArray(array);

int[] InputNumb(int x, int[] array)
{
    for (int i = 0; i < x; i++) 
    {
        Console.WriteLine($"Введите {i} элемент массива");
        array[i] = array[i] + Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int [] array)
{
    for (int i=0;i<array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}