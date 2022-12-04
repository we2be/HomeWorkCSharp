// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9 программу вычисления функции Аккермана с помощью рекурсии

// m = 3, n = 2 -> A(m,n) = 29




Console.WriteLine("Программа вычисления функции Аккермана с помощью рекурсии.");

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




int AkkermanFunction(int numM, int numN)

{

    if (numM == 0) return numN + 1;

    else if (numM > 0 && numN == 0) return AkkermanFunction (numM - 1, 1);

    return AkkermanFunction(numM - 1, AkkermanFunction(numM, numN - 1));


}    




int result = AkkermanFunction(numberM, numberN);

Console.WriteLine($"Для чисел М: {numberM} и N: {numberN} результат функции Аккермана равен {result}");