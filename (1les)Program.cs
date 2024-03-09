// Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

Console.Write("введите значение M: ");
int M = int.Parse(Console.ReadLine());

Console.Write("введите значение N: ");
int N = int.Parse(Console.ReadLine());

if (M <= N)
{
    PrintNumbersInRange(M, N);
}
else
{
    PrintNumbersInRange(N, M);
}

    static void PrintNumbersInRange(int M, int N)
{
    if (M <= N)
    {
        Console.WriteLine(M);
        PrintNumbersInRange(M + 1, N);
    }
}
