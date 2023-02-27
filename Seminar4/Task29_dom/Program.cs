// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}
int number1 = ReadNumber("Введите число 1");
int number2 = ReadNumber("Введите число 2");
int number3 = ReadNumber("Введите число 3");
int number4 = ReadNumber("Введите число 4");
int number5 = ReadNumber("Введите число 5");
int number6 = ReadNumber("Введите число 6");
int number7 = ReadNumber("Введите число 7");
int number8 = ReadNumber("Введите число 8");
int[] array = new int[] { number1, number2, number3, number4, number5, number6, number7, number8 };
Console.Write($"[{string.Join(", ", array)}]");