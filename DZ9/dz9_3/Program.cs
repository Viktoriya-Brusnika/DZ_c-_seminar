// **Задача 68:**Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29


Console.WriteLine("Введите натуральное неотрицательное число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное неотрицательное число n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FuncAkkerman(m, n));

int FuncAkkerman(int m, int n)

{
    {
        if (m == 0) return n + 1;
        if (n==0) return FuncAkkerman(m - 1, 1);
        return FuncAkkerman(m - 1, FuncAkkerman(m, n - 1));
    }

}