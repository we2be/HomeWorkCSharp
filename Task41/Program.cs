// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 пользователя.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел для ввода: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayUserElem(int size)
{
    int[] array = new int[size];
    int elements = default;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        elements = Convert.ToInt32(Console.ReadLine());
        array[i] = elements;
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i], 4} |");
        else Console.Write($"{array[i], 4}");
    }
    Console.WriteLine(" ]");
}

int CountPositiveElememtsInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int[] userArray = CreateArrayUserElem(num);
Console.WriteLine("-------");
Console.WriteLine("массив пользователя");
PrintArray(userArray);
Console.WriteLine("-------");
int countPositiveElementsInArray = CountPositiveElememtsInArray(userArray);
Console.WriteLine($"сколько чисел больше 0 ввёл пользователь => {countPositiveElementsInArray}.");