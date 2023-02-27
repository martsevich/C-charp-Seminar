// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}


int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange);
    }
    return array;
}

int IsElementInArray (int[] array)
{
    int sumEven = 0;
    for  (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
           sumEven = sumEven + 1;
        }
        else {}
    }
    return (sumEven);
}

int lengthOfArray = ReadNumber("Задайте длину массива: ");

int[] myArray = GetRandomArray(lengthOfArray, 99, 1000);

Console.WriteLine($"[{string.Join(", ", myArray)}]");
int res = IsElementInArray(myArray);
Console.WriteLine("Количество чётных чисел в массиве: " + res);
