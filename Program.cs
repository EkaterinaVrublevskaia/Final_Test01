//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести 
//с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется 
//пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Write("Сколько элементов Вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите элементы через пробел: ");

string[] array = ArrayString(size);
printArray(array);
string[] arrayResult = ArrayResult(array);
printArray(arrayResult);


string [] ArrayResult(string[] array)
{
    string[] arr = new string[array.Length];
    int number = 3;
    var j = 0;
    for(int k = 0; k < array.Length; k++)
    {
        if(array[k].Length <= number)
        {
            arr[j] = array[k];
            j++;            
        }    
    } 
    return arr;
}

string [] ArrayString(int arrayLength)
{
    string[] array = new string[arrayLength];
    int i = 0;
    for (i = 0; i < array.Length; i++)
    {
        string output = Console.ReadLine();
        array[i] = output;
    }
    return array;
}


void printArray(string[] array)
    {
        Console.Write("[ ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("'");
            Console.Write($"{array[i]}");
            Console.Write("', ");
        }
        Console.Write("]");
        Console.WriteLine();
    }

