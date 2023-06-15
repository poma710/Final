
**Описание программы:** 

Программа на языке C# позволяет отфильтровать массив строк. После фильтрации будут выведены только те строки, длина которых меньше или равна 3 символам.

**Структура программы:**

Программа содержит один класс Program. Основная функция Main() выполняет следующие действия:

1. Создание массива строк strings, содержащего значения "12345", "5896", "hijklmn", "op", "yes", "777".
2. Создание нового массива строк newStrings с помощью конструктора new string[strings.Length].
3. Создание переменной k и присвоение ей значения 0.
4. Цикл for перебирает элементы массива strings.
5. Если длина строки меньше или равна 3 символам, то значение записывается в новый массив строк newStrings и индекс k увеличивается на 1.
6. Цикл for выводит отфильтрованные строки на экран.

**Как использовать:**

- Откройте программу в среде программирования, поддерживающей язык C#.
- Запустите программу.
- Результат работы программы будет выведен на экран.
**Пример вывода программы:**

Строки, длина которых меньше или равна 3 символам: 5896 op yes 777

