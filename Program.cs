//  Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
//  либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

public class Program { public static void Main() { Console.Write("Введите количество строк: "); int n = int.Parse(Console.ReadLine());

    string[] strings = new string[n]; // создание массива строк
    for (int i = 0; i < n; i++) {
        Console.Write($"Введите строку номер {i + 1}: ");
        strings[i] = Console.ReadLine();
    }

    string[] newStrings = new string[n]; // создание нового массива строк
    int k = 0; // счетчик нового массива
    for (int i = 0; i < n; i++) {
        if (strings[i].Length <= 3) {
            newStrings[k] = strings[i];
            k++;
        }
    }

    Console.WriteLine("Строки, длина которых меньше или равна 3 символам:");
    for (int i = 0; i < k; i++) {
        Console.WriteLine(newStrings[i]);
    }
}
}