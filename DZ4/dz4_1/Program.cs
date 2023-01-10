// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число В");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"А в степен В равна {Expon(A, B)}");

int Expon (int x, int y)
{
    int res = 1;
    for (int i = 1; i < y+1; i++)
    {
        res = res * x;
    }
    return res;
}
