// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. 
// Определить , является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, 
// является ли он прямоугольным, равнобедренным, равносторонним.

Console.WriteLine("Введите 1 целое положительное число");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите 2 целое положительное число");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите 3 целое положительное число");
double c = Convert.ToDouble(Console.ReadLine());

if (a <= 0 || b <= 0 || c <= 0) Console.WriteLine("Ну ё-маё, просила же ПОЛОЖИТЕЛЬНОЕ число");
else
{
    if (a + b > c && b + c > a && a + c > b)
    {
        Console.WriteLine("Да, это могут быть стороны треугольника");
        double P = a + b + c;
        Console.WriteLine($"Периметр = {P}");
        double Area = Math.Sqrt(P / 2 * (P / 2 - a) * (P / 2 - b) * (P / 2 - c));
        Console.WriteLine($"Площадь = {Area}");
        Console.WriteLine("{0:F3}", Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180 / Math. PI);
        Console.WriteLine("{0:F3}", Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180 / Math. PI);
        Console.WriteLine("{0:F3}", Math.Acos((b * b + c * c - a * a) / (2 * c * b)) * 180 / Math. PI);
        if ((Math.Pow(a, 2)) + Math.Pow(b, 2) == Math.Pow(c, 2) || (Math.Pow(b, 2)) + Math.Pow(c, 2) == Math.Pow(a, 2) || (Math.Pow(a, 2)) + Math.Pow(c, 2) == Math.Pow(b, 2)) Console.WriteLine("Треугольник прямоугольный");
        if (a == b || b == c || a == b) Console.WriteLine("Треугольник равнобедренный");
        if ( a == b && b == c ) Console.WriteLine("Треугольник равносторонний");


    }
    else Console.WriteLine("Нет, эти значения не могут быть длинами треугольника");

}

