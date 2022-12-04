// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
while (numberM < 0)
{
    Console.WriteLine("Вы ввели отрицательное число!");
    Console.Write("Введите натуральное число M: ");
    numberM = Convert.ToInt32(Console.ReadLine());
}

while (numberN < 0)
{
    Console.WriteLine("Вы ввели отрицательное число!");
    Console.Write("Введите натуральное число N: ");
    numberN = Convert.ToInt32(Console.ReadLine());
}


int SumNaturalNumbers(int numM, int numN)
{
    if (numM == numN) return numM;   
    if (numM < numN) return numM + SumNaturalNumbers(numM + 1, numN);
    if (numM > numN) return numM + SumNaturalNumbers(numM - 1, numN);
    return numM;
}

int sum = SumNaturalNumbers(numberM, numberN);
Console.WriteLine($"Cумма натуральных элементов в промежутке от M - {numberM} до N - {numberN} равна {sum}");