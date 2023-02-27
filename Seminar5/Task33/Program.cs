// Задача 33: 
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int ReadNumber(string messageToUser)
{
    Console.Write(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[] GetRandomArray(int length,int leftRange,int rightRange)
{
    int[] array = new int[length];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }
    return array;
}

// true number найден в array
// false number НЕ найден в array
bool IsElementInArray (int[] array, int number)
{
    bool temp = false;

    for  (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
           temp = true;
           break;
        }
    }
    return temp;
}

int length = ReadNumber("Задайте длину массива: ");
int leftRange = ReadNumber("Задайте левую границу случайного диапазона: ");
int rightRange = ReadNumber("Задайте правую границу случайного диапазона: ");
int find = ReadNumber("Введите число для поиска: ");

int[] array = GetRandomArray(length, leftRange, rightRange);

Console.WriteLine($"[{string.Join(", ", array)}]");
bool res = IsElementInArray(array, find);
Console.WriteLine(res);
