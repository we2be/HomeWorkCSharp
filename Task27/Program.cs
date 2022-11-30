// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigit(int number)
{
    int sum = 0;
    int digit = default;
    number = Math.Abs(number);
    while (number > 0)
    {
        digit = number % 10;
        sum += digit;
        number /= 10;
    }
    return sum;
}

int sumDigit = SumDigit(num);
Console.WriteLine($"Сумма цифр в числе {num} => {sumDigit}");