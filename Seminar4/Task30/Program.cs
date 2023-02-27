// // Задача 30: 
// // Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// // [1,0,1,1,0,1,0,0]

int[] array = new int[8];
// Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = Random.Shared.Next(0, 2);
    //Console.Write(array[i] + ",");
}
Console.Write($"[{string.Join(",", array)}]");
// Console.Write("]");


// void FillRandomArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Random.Shared.Next(0, 2);
//     }
// }
// // int[] array = new int[number];
// FillRandomArray(array);
// Console.Write($"[{string.Join(",", array)}]");
