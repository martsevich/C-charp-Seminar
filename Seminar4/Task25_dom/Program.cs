// Задача 25:
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}
int SumToA(int a, int b)
{
    int c = 0;
    int a1 = a;
    if (b < 0)
    {
     Console.Write("Error");
    }
    else    
        for (int i = 0; i < b - 1; i++)
        {
            c = a1 * a;
            a1 = c;
        }
        return a1;
}
int a = ReadNumber("Введите число A");
int b = ReadNumber("Введите число B");
int result = SumToA(a, b);
// double result = Math.Pow(a,b); // возведение а в степени в
Console.Write(" -> " + result);