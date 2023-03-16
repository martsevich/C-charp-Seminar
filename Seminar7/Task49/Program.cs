// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.

// Например, изначально массив          Новый массив будет выглядеть 
//  выглядел вот так:                   вот так:
// 1 4 7 2                              1 4 7 2
// 5 9 2 3                              5 81 2 9
// 8 4 2 4                              8 4 2 4

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetRandomMatrix(int rows, int columns, int leftBorder = 0, int rightBorder = 10)
{
    int[,] matrix = new int[rows, columns];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
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

void SquareOddIndexes(int[,] matrix)
{
    for(int i = 1; i < matrix.GetLength(0); i += 2)
    {
        for(int j = 1; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] = matrix[i, j] * matrix[i, j];
            //matrix[i, j] *= matrix[i, j];
        }
    }
}

int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
SquareOddIndexes(myMatrix);
Console.WriteLine();
PrintMatrix(myMatrix);

