// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// √(xb - xa)2 + (yb - ya)2

// double a = 4;
// double b = 2;
// // double c = Math.Pow(a, 0.5); 
// double c = Math.Pow(a, b); // x ^ y
// Console.WriteLine(c);

// double d = Math.Sqrt(c);
// Console.WriteLine(d);

Console.WriteLine("Введите координату точки по X1:");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату точки по Y1:");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату точки по X2:");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату точки по Y2:");
double yb = Convert.ToDouble(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
Console.WriteLine($"{d:f2}");