// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Веедите число a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Веедите число b:");
int b = Convert.ToInt32(Console.ReadLine());

if (a * a == b || b * b == a)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}
