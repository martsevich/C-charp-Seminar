// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 1 && a <= 7)
{
    if (a == 1 || a == 2 || a == 3 || a == 4 || a == 5)
    {
        Console.WriteLine("нет");
    }
    if (a == 6 || a == 7)
    {
        Console.WriteLine("да");
    }
}
else
{
    Console.WriteLine("в недели нет такого дня");
}

