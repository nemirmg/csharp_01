int n = 5;
int[] array = [2, 4, 7, 3, 9];
int i = 0;
int max = array[i];
while (i < array.Length){
    if (array[i] > max){
        max = array[i];
    }
    i++;
}
Console.WriteLine($"Самая тяжёлая гиря весит {max} кг.");

max = array[0];
for (int j = 0; j < n; j = j + 1)
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
Console.WriteLine(max);

max = array[0];
foreach (int e in array)
{
    if (e > max)
    {
        max = e;
    }
}
Console.WriteLine(max);