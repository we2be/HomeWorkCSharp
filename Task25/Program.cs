// Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int numA, int numB)
{
    int expon = numA;
    for (int i = 1; i < numB; i++)
    {
        expon *= numA;
    }
    return expon;
}

if (numberB<0) {
    Console.WriteLine($"Число В отрицательное : {numberB}.");
    numberB = Math.Abs(numberB);
    Console.WriteLine($"Преобразуем его в натуральное : {numberB}.");
}
int exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine($"Число {numberA} возведенное в {numberB} степень = {exponentiation}");