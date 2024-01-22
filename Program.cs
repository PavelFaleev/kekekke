using System;

class Program

    static void Main()
    {
        
        string[] inputStrings1 = { "Hello", "2", "world", ":-)" };
        string[] resultStrings1 = FilterArray(inputStrings1);
        Console.WriteLine("Результат 1: [" + string.Join(", ", resultStrings1) + "]");

        string[] inputStrings2 = { "1234", "1567", "-2", "computer science" };
        string[] resultStrings2 = FilterArray(inputStrings2);
        Console.WriteLine("Результат 2: [" + string.Join(", ", resultStrings2) + "]");

        string[] inputStrings3 = { "Russia", "Denmark", "Kazan" };
        string[] resultStrings3 = FilterArray(inputStrings3);
        Console.WriteLine("Результат 3: [" + string.Join(", ", resultStrings3) + "]");
    }
