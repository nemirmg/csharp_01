void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (int element in arr)
    {
        Console.Write($"{element} ");
    }
}

int[] array = [1, 2, 3, 4, 5];
ZeroEvenElements(array);
PrintArray(array);