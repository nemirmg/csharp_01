int fact(int n){
    if (n == 1){
        Console.WriteLine($"Stop: {n}");
        return 1;
    }
    Console.WriteLine(n);
    int result = fact(n - 1);
    Console.WriteLine($"Возврат: n = {n}, fact = {result}");
    return n * result; 
}

Console.WriteLine(fact(5));