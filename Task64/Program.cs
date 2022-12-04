// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int num) //5
{
    if (num > 0)
    {
        Console.Write($"{num} ");
        NaturalNumbers(num-1);        
    }
}

while (number < 0) 
{
    Console.WriteLine("Вы ввели не натуральное число.");
    Console.Write("Введите натуральное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}
NaturalNumbers(number);