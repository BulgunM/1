// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i],3}, ");
    }
    Console.Write($"{arr[arr.Length - 1],3}");
    Console.WriteLine("]");
}

string[] NewArraySize(string[] arr)
{
    int size = 0;
    string[] newArr;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j].Length <= 3) size++;
    }
    newArr = new string[size];
    return newArr;
}

string[] FillNewArray(string[] arr, string[] newArr)
{
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[j] = arr[i];
            j++;
        }
    }
    return newArr;
}

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите элементы массива через запятую:");
string[] array = Console.ReadLine()!.Split(',');

PrintArray(array);

string[] newArray = NewArraySize(array);
if (newArray.Length > 0)
{
    string[] result = FillNewArray(array, newArray);
    PrintArray(newArray);
}
else Console.WriteLine("В заданном массиве нет элементов, длина которых меньше 4 символов");