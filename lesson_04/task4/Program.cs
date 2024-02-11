Console.Clear();
Console.WriteLine(@"Домашнее задание:
Считать с консоли строку, состоящую из цифр и
латинских букв. Сформировать массив, состоящий
из цифр этой строки.
----------
Пример
abc123def06g => [1, 2, 3, 0, 6]");

string GetDigitsFromString(string line){
    string digits = "";
    foreach (char element in line){
        if (char.IsDigit(element))
            digits += element;
    }
    return digits;
}

int[] ConvertStringOfDigitsToArray(string line){
    int[] array = new int[line.Length];
    for (int i = 0; i < line.Length; i++){
        array[i] = int.Parse(line[i].ToString());
    }
    return array;
}

Console.Write("\nВведите строку символов: ");
string str = Console.ReadLine()!;
int[] result = ConvertStringOfDigitsToArray(GetDigitsFromString(str));
Console.WriteLine($"[{string.Join(", ", result)}]");