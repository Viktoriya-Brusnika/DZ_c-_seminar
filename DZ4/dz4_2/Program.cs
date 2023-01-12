// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число, а я посчитаю сумму его цифр");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел равна {SumDigit(a)}");

int SumDigit(int x)
{
    int res = 0;
    for (int i = 1; i <= Length(x); i++) res = res + (x % ((int)Math.Pow(10, i)) / (int)Math.Pow(10, i - 1));
    return res;
}


int Length(int y)
{
    int res1 = 0;
    for (int i = 1; i < y; i = i * 10) res1 += 1;
    return res1;
}