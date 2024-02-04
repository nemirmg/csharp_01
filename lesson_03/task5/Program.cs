// заполнение массива случайными значениями из интервала

Random rnd = new Random();
int size = 1000;
int[] arr_int = new int[size];
int i = 0;
while (i < size)
{
    arr_int[i] = rnd.Next(1, 10);
    Console.Write($"{arr_int[i]} ");
    i = i + 1;
}