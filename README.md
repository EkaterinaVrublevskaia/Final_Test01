# Итоговый тест

ЗАДАЧА:

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Алгоритм выполнения задания:

    1. Создать репозиторий на GitHub
    2. Нарисовать блок-схему алгоритма
    3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
    4. Написать программу, решающую поставленную задачу

* Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

### 1. Создать репозиторий на GitHub

Создан репозиторий Final_Test01 с файлом README.md

### 2. Создание алгоритма решения задачи

Прикреплен файл с изображением блок-схемы.

### 3. Описание алгоритма решения задачи

Пользователь указывает сколько элементов (size) он хочет задать и заполняет стартовый массив элементами в цикле.
Далее создаем массив строк вводимый пользователем в методе и выводим его на экран. 
Создаем второй метод, в котором проходимся по стартовому массиву в цикле и проверяем, подходит ли элемент условию "длина символов <= 3". Если элемент подходит под данное условие, то мы добавляем его в новый массив, используя при этом дополнительный счетчик, чтобы элементы в новом массиве заполнялись последовательно (без пропусков).

### 4. Решение задачи на C#

В fail Program.cs решение задачи на C#.
Решение с помощию методов. 
В первом методе создаем массив строк выведенный пользователем. решение с помощью двух массивов, Во втором методе проверяем по условию "длина символов <= 3 и если "да", то элменты поочереждно  добавляются в массив строк
Создан третьй метод void, который вывод результат первого масива строк и результат второго массива строк (решение задачи). 