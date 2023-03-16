// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int n = 15;
int m = 1;
int result = 0;
PrintMToN(m, n);
Console.WriteLine(result); 

void PrintMToN(int start, int end)
{
    if (end < start) return;
    PrintMToN(start, end - 1);
    result = result + end;
}