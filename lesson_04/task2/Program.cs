//---------------
// Моё решение

// int[,] CreateMatrix(int rowCount, int columnCount){
//     int[,] matrix = new int[rowCount, columnCount];
//     Random rnd = new Random();
//     for (int i = 0; i < rowCount; i++){
//         for (int j = 0; j < columnCount; j++){
//             matrix[i, j] = rnd.Next(0, 1001);
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
//     return matrix;
// }

// bool EvenParity(int number){
//     int sum = SummaDigits(number);
//     if (sum % 2 == 0)
//         return true;
//     return false;
// }

// int SummaDigits(int number){
//     if (number < 0)
//         number *= -1;
//     int sum = 0;
//     while (number > 0){
//         sum += number % 10;
//         number /= 10;
//     }
//     return sum;
// }

// void ShowInterestingElements(int[,] matrix){
//     for (int i = 0; i < matrix.GetLength(0); i++){
//         for (int j = 0; j < matrix.GetLength(1); j++){
//             if (EvenParity(matrix[i, j]))
//                 Console.Write($"{matrix[i, j]} ");
//         }
//     }
// }

// Console.Clear();
// Console.Write("Введите через пробел размеры 2D массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();

// int[,] matrix = CreateMatrix(size[0], size[1]);
// ShowInterestingElements(matrix);

//---------------
// Лекционное решение

int[,] CreateMatrix(int rowCount, int columnCount)
{
    int[,] matrix = new int[rowCount, columnCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(3, 4);
ShowMatrix(matrix);
foreach (int element in matrix){
    if (IsInteresting(element))
        Console.WriteLine(element);
}

bool IsInteresting(int value){
    if (GetSumOfDigits(value) % 2 == 0)
        return true;
    return false;
}

int GetSumOfDigits(int value){
    int sum = 0;
    while (value > 0){
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}