// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введи число, и я покажу тебе третью цифру");
string a = Console.ReadLine();
int x = a.Length;
int b = Convert.ToInt32 (a);


switch(x)
{
    case 1:
    Console.WriteLine("Третьей цифры нет!");
    break;

    case 2:
    Console.WriteLine("Третьей цифры нет!");
    break;

    case 3:
    Console.WriteLine($"Третья цифра {b %10}");
    break;

    case 4:
    Console.WriteLine($"Третья цифра {b %100/10}");
    break;

    case 5:
    Console.WriteLine($"Третья цифра {b %1000/100}");
    break;

    case 6:
    Console.WriteLine($"Третья цифра {b %10000/1000}");
    break;

    case >6:
    Console.WriteLine($"Не, это уже перебор, сбавь обороты и напиши число до 1 000 000");
    break;

}
// if ( x<3 ) 
// {
//     Console.WriteLine("Третьей цифры нет!");
// }

// else 
// {
//     int a2 = (a % 100)/10;
//     Console.WriteLine(a2);
// }