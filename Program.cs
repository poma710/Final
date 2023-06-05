//  Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
//  либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using System;

public class Program { public static void Main() { string[] strings = {"abc", "defg", "hijklmn", "op", "qrs"}; 

    string[] newStrings = new string[strings.Length]; 
    int k = 0; 
    for (int i = 0; i < strings.Length; i++) {
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
