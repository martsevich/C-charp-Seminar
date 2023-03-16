// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int myNumber = 453;

Console.WriteLine(SumDigits(myNumber));

int SumDigits(int number)
{
    if (number == 0) return 0;
    return number % 10 + SumDigits(number / 10);
}
