﻿// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
// число number четное и больше 10
if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("ДА");
}
else
{
     Console.WriteLine("НЕТ");
}
