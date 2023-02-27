// Задача 32: 
// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

int[] InvertElements(int[] array)
{
    for  (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

int length = ReadNumber("Задайте длину массива: ");
int leftRange = ReadNumber("Задайте левую границу случайного диапазона: ");
int rightRange = ReadNumber("Задайте правую границу случайного диапазона: ");
int[] array = GetRandomArray(length, leftRange, rightRange);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"[{string.Join(", ", InvertElements(array))}]");
 