// Задача 27:
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int CountOfDigits(int number)
{
    int sum = 0;
    for (int i = 0; number != 0; i++)
    {
        int number1 = number % 10;
        sum = sum + number1;
        number = number / 10;
    }
    return sum;
}
int userNumber = ReadNumber("Введите число:");
int result = CountOfDigits(userNumber);
Console.Write(" -> " + result);