// Домашняя работа

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i = i + 1)
{
    int a = i % 2;
    
        if (a == 0)
        {
            Console.Write(i + ",");
        }   
        else
        {
            Console.Write(" ");
        } 
}
