// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int n = 8;
int m = 4;
PrintMToN(m, n);

void PrintMToN(int start, int end)
{
    if (end < start) return;
    PrintMToN(start, end - 1);
    Console.Write($"{end} ");
}