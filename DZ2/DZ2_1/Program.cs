﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число, и я напишу вторую цифру этого числа");
int a = Convert.ToInt32 (Console.ReadLine());

if ( a < 100 || a > 999 ) 
{
    Console.WriteLine("Я что, шутка для тебя? Я просила трехзначное число!");
}

else 
{
    int a2 = (a % 100)/10;
    Console.WriteLine(a2);
}

