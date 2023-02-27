// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = Random.Shared.Next(100, 1000);
Console.WriteLine(number);
int lastDigit = number % 10;
int firstDigit = number / 100;
int res = firstDigit * 10 + lastDigit;

Console.WriteLine(res);
