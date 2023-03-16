// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int number = 1;
int end = 8;
Print1ToN(number);

void Print1ToN(int n)
{
    if (n > end) return;
    Print1ToN(n + 1);
    Console.Write($"{n} ");
}