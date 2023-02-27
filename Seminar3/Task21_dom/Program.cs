// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int xa = ReadNumber("Введите координату точки по X1:");
int ya = ReadNumber("Введите координату точки по Y1:");
int za = ReadNumber("Введите координату точки по Z1:");
int xb = ReadNumber("Введите координату точки по X2:");
int yb = ReadNumber("Введите координату точки по Y2:");
int zb = ReadNumber("Введите координату точки по Z2:");

double AB = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
Console.WriteLine($"{AB:f2}");