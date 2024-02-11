string GetLettersFromString(string line){
    string letters = "";
    foreach (char element in line){
        if (char.IsLetter(element))
            letters += element;
    }
    return letters;
}

Console.Clear();
Console.Write("Введите строку символов: ");
string str = Console.ReadLine()!;
string result = GetLettersFromString(str);
Console.WriteLine(result);