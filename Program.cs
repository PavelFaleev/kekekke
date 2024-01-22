using System;

class Program
{
    static void Main()
    {
        
        
        string[] inputStrings = { "Hello", "2", "world", ":-)" };

        // Формирование нового массива
        string[] resultStrings = FilterArray(inputStrings);

        // Вывод результата
        Console.WriteLine("Результат: [" + string.Join(", ", resultStrings) + "]");
    }

