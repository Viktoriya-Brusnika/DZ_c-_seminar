// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату х точки А");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки А");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z точки А");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату х точки В");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки В");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z точки В");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Расстояние равно {Dist(x1, y1, z1, x2, y2, z2)}");

double Dist(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double D = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return D;
}