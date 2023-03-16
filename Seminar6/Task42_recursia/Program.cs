int n = 44;


void PrintBinary(int n)
{
    if (n == 0) return;
    PrintBinary(n / 2);
    Console.Write(n % 2);
}

PrintBinary(n);

