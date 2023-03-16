// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных                    Частотный массив
// 1, 2, 3                         1 встречается 3 раза 
// 4, 6, 1                         2 встречается 2 раз 
// 2, 1, 6                         3 встречается 1 раз 
//                                 4 встречается 1 раз 
//                                 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9

// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetRandomMatrix(int rows, int columns, int leftBorder = 0, int rightBorder = 9)
{
    int[,] matrix = new int[rows, columns];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintRepeats(int[,] matrix)
{
    int[] repeats = new int[10];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            int index = matrix[i, j];
            repeats [index]++;
            //repeats[matrix[i, j]]++;
        }
    }

    for (int i = 0; i < repeats.Length; i++)
    {
        Console.WriteLine($"{i} повторяется {repeats[i]} раз");
    }
}

int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
PrintRepeats(myMatrix);