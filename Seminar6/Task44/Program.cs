// Задача 44: 
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// f(n) = f(n-1) + f(n-2)

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int N = ReadNumber("Введите десятичное число: ");

// const int N = 5;

int[] Fi = new int[N];

Fi[0] = 0;
Fi[1] = 1;

for(int i = 2; i < Fi.Length; i++)
{
    Fi[i] = Fi[i - 1] + Fi[i-2];
}

Console.WriteLine(string.Join(" ", Fi));
