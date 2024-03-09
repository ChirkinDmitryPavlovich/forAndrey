// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

Console.Write("введите число m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("введите число n: ");
int n = int.Parse(Console.ReadLine());

if (m < 0 || n < 0)
{
    Console.WriteLine("числа m и n должны быть неотрицательными.");
    return;
}

int result = AckermannFunction(m, n);
Console.WriteLine($"результат функции Аккермана для m = {m} и n = {n} равен {result}");

    static int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}
