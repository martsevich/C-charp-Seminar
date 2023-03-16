// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int a = ReadNumber("Введите десятичное число: ");
int number = 0;
int temp = a;

while(temp !=0)
{
    temp/=2;
    number++;
}

int[] binaryNumber = new int[number];
for( int i = 0; i < binaryNumber.Length; i++)
{
    binaryNumber[i] = a % 2;
    a /= 2;
}

RevAr (binaryNumber);
Console.WriteLine(string.Join("", binaryNumber));

void RevAr(int [] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array [array.Length - i - 1];
        array [array.Length - i - 1] = temp;
    }
}