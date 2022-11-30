// Задача 29: Напишите программу, которая задаёт
// массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int sizeDigit = 8; // количество элементов массива

int[] SizeArray(int size)
{
    int[] array = new int[size]; //
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 100);
    }
    return array;
}

void PrintArray(int[] array)
{   
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i<array.Length-1) Console.Write(", ");
    }
    Console.Write("]");
}

int[] sizeArray = SizeArray(sizeDigit);
Console.WriteLine("Вывод массива из 8 элементов заполненный случайными числами : ");
PrintArray(sizeArray);