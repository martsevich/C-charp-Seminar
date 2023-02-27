// Задача 24: Напишите программу, которая принимает на
// вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int SumToA(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
         //sum = sum + i;
         sum += i;   
    }
    return sum;
}
int number = ReadNumber("Введите число А");
int result = SumToA(number);
Console.Write(" -> " + result);