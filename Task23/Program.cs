// Задача 23
// Напишите программу, которая принимает 
// на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125


void ToCube(int num) 
{
    // Вариант 1. Если не знаем Math.Pow
    // int count=1;
    // while (count<=num) {
    //     int cube = count; 
    //     for (int i=1; i<3; i++) { cube *= count; }
    //     Console.WriteLine($"|{count,4} | {cube,4}|"); 
    //     count++;
    // }

    // Вариант 2. Если знаем Math.Pow
    for (int i=1; i<=num; i++) 
    {
        double cube = Math.Pow(i, 3);    
        Console.WriteLine($"|{i,4} | {cube,4}|"); 
    }
}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
ToCube(number);