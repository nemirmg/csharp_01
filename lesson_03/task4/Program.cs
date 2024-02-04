void FillArray(int[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        array[i] = i + 1;
        i++;
    }
}

void PrintArray(int[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        Console.Write($"{array[i]} ");
        i++;
    }
    Console.WriteLine();
}

int GetSumOfElements(int[] array)
{
    int i = 0;
    int summa = 0;
    while (i < array.Length)
    {
        summa += array[i];
        i++;
    }
    return summa;
}

int GetProductOfElements(int[] array)
{
    int i = 0;
    int product = 1;
    while (i < array.Length)
    {
        product *= array[i];
        i++;
    }
    return product;
}


int n = 10;
int[] arr = new int[n];
FillArray(arr);
PrintArray(arr);
int sum = GetSumOfElements(arr);
int product = GetProductOfElements(arr);
Console.WriteLine(sum);
Console.WriteLine(product);