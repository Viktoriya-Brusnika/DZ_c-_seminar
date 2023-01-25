// Задача 60. ...Сформируйте трёхмерный массив из уникальных двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите 1 измерение");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 измерение");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 измерение");
int c = Convert.ToInt32(Console.ReadLine());
int [,,] array = new int[a,b,c ];
FillArray(array);
PrintArray(array);


void FillArray(int[,,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
        for (int j=0;j<array.GetLength(1);j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = new Random().Next(0,100);
            }
            
}

void PrintArray(int[,,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i,j,k]} ({i},{j},{k}) \t ");
                Console.WriteLine();
        }
            
    }
        
            
}