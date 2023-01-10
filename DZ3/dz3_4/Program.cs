// Задача 21 - HARD необязательная

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве.
// Сначала задается N с клавиатуры, потом задаются координаты точек.

Console.WriteLine("Введите размерность пространства");
int N = Convert.ToInt32(Console.ReadLine());

for (int i=1; i<N+1; i++)
{
    Console.WriteLine($"Введите х{i} координату точки А");
    double x = Convert.ToDouble(Console.ReadLine());
}

for (int j=1; j<N+1; j++)
{
    Console.WriteLine($"Введите х{j} координату точки В");
    double y = Convert.ToDouble(Console.ReadLine());
}


// double Dist(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     double D = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
//     return D;
// }

// double sum = 0;
// for (int k = 1; k<N+1; k++)
// {
//     sum = sum + Math.Pow((x - x1), 2)
// }