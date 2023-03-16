//Вычислить факториал введенного числа N
// 4 -> 24
// 5 -> 120

uint number = 4;

uint Factorial(uint n)
{
    if (n == 0) return 1;
    if (n == 1) return 1;
    uint result = n * Factorial(n - 1);
    return result;
}
Console.WriteLine(Factorial(number));

// int number = 4;

// int Factorial(int n)
// {
//     if (n < 0) throw new Exception($"Невозможно высчитать факториал числа {n}");
//     if (n == 0 || n == 1) return 1;
//     return n * Factorial(n - 1);
// }

// Console.WriteLine(Factorial(number));