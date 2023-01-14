// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число");
// char[] a = Console.ReadLine().ToCharArray();


// if (a.Length > 5) Console.WriteLine("ввели неверные данные");
// else if (a[0] == a[4] || a[1] == a[3]) Console.WriteLine("Да, это палиндром");
// else Console.WriteLine("Нет, это не палиндром");


 using System;

namespace PalindromeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a five-digit number:");
            int number = int.Parse(Console.ReadLine());
            int firstDigit = number / 10000;
            int secondDigit = (number / 1000) % 10;
            int thirdDigit = (number / 100) % 10;
            int fourthDigit = (number / 10) % 10;
            int fifthDigit = number % 10;

            if (firstDigit == fifthDigit && secondDigit == fourthDigit)
            {
                Console.WriteLine("The number is a palindrome.");
            }
            else
            {
                Console.WriteLine("The number is not a palindrome.");
            }
        }
    }
}