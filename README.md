# FinalProject-1quarter
Задача. Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равна 3 символа.
Примеры:
[hello, 2, world, :-)] -> [2, :-)]
[12, 1567, -2, computer science] -> [12, -2]
[1234, 1567, -2456, computer science] -> []

Ход решения:
1. Начальный массив задаётся в коде программы
2. Пишем функцию печати массива и проверяем её.
3. Пишем функцию Поиска элементов, длина которых меньше либо равна 3 символа.
   * Найденные элементы сохраняем в строковую переменную temp через пробел.
   * Затем создаём массив и с помощью метода Split разбиваем переменную temp по элементам.
4. Проверяем работу программы
5. Устраняем ошибки. Добавляем условие, если элементы меньше 3 символов не находятся
