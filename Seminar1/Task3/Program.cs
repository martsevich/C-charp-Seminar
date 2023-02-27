// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Введите число:");
string answer = Console.ReadLine();
int a = Convert.ToInt32(answer);

if (a==1)
{
    Console.WriteLine("понедельник");
}
if (a==2)
{
    Console.WriteLine("вторник");
}
if (a==3)
{
    Console.WriteLine("среда");
}
if (a==4)
{
    Console.WriteLine("четверг");
}
if (a==5)
{
    Console.WriteLine("пятница");
}
if (a==6)
{
    Console.WriteLine("суббота");
}
if (a==7)
{
    Console.WriteLine("воскресенье");
}
if (a>7)
{
    Console.WriteLine("нет такого дня недели");
}
if (a<1)
{
    Console.WriteLine("нет такого дня недели");
}