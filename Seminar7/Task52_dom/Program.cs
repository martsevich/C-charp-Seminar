// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// ​Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double GetArifmetOfMainDiagonal(int[,] matrix)
{
    double sum = 0;
    double srArif1 = 0;
    int j = 0;
    for(int i = 0; i < matrix.GetLength(1); i++)
        {
            sum += matrix[i,j];
            srArif1 = sum / (i + 1);
        }
        return srArif1;
}
double GetArifmetOfMainDiagonal2(int[,] matrix)
{
    double sum = 0;
    double srArif1 = 0;
    int j = 0;
    for(int i = 0; i < matrix.GetLength(1); i++)
        {
            sum += matrix[i,j];
            srArif1 = sum / (i + 1);
        }
        return srArif1;
}
int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
int[,] myMatrix2 = GetRandomMatrix(m, n);
// PrintMatrix(myMatrix2);
Console.WriteLine($"{GetArifmetOfMainDiagonal(myMatrix):f1}" + " " + $"{GetArifmetOfMainDiagonal2(myMatrix2):f1}");