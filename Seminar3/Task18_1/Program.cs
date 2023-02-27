// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).
// 1 -> “x > 0 && y > 0” 
// 2 -> “x < 0 && y > 0” 
// 3 -> “x < 0 && y < 0” 
// 4 -> “x > 0 && y < 0”
// 5 -> “Неверно введен номер четверти” 

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int x = ReadNumber("Введите число:");
if (x == 1)
{
    Console.WriteLine("x > 0 && y > 0");
}
else if (x == 2)
{
    Console.WriteLine("x < 0 && y > 0");
}
else if (x == 3)
{
    Console.WriteLine("x < 0 && y < 0");
}
else if (x == 4)
{
    Console.WriteLine("x > 0 && y < 0");
}
else 
{
    Console.WriteLine("Неверно введен номер четверти");
}