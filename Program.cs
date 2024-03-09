// Задайте произвольный массив.
// Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

void PrintArrayFromEnd(int[] arr, int index)
{
    if (index < 0)
    {
        return;
    }
    else
    {
        Console.WriteLine(arr[index]);
        PrintArrayFromEnd(arr, index - 1);
    }
}

    Console.Write("введите количество элементов в массиве: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[] myArray = new int[n];

    Console.WriteLine("введите элементы массива:");
    for (int i = 0; i < n; i++)
    {
        Console.Write($"элемент {i + 1}: ");
        myArray[i] = Convert.ToInt32(Console.ReadLine());
    }

    PrintArrayFromEnd(myArray, myArray.Length - 1);