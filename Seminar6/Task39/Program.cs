// int numberInt = Random.Shared.Next(1, 10);
// double numberDouble = Random.Shared.NextDouble() * 100 - 20;
// double[] doubles = new double[] {2.35345345, 1.392391392, 234.234236546 };
// Console.WriteLine($"{string.Join(", ", doubles.Select(x => Math.Round(x, 2)))}"); // [-20.0, 80.0)

// https://metanit.com/sharp/tutorial/7.5.php

int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }
    return array;
}

const int LENGTH = 6; // нельзя перезаписывать такие данные
const int LEFTBORDER = -10;
const int RIGHTBORDER = 10;

void RevAr(int [] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array [array.Length - i - 1];
        array [array.Length - i - 1] = temp;
    }
}

int[] myArray = GetRandomArray(LENGTH, LEFTBORDER, RIGHTBORDER);
Console.WriteLine(string.Join(", ", myArray));
RevAr(myArray);
Console.WriteLine(string.Join(", ", myArray));
