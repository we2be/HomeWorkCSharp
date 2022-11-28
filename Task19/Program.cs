// Задача 19
// Напишите программу, которая принимает 
// на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Polindrome(int num)
{
    int digit1 = num / 10000;
    int digit2 = num / 1000 % 10;
    int digit4 = num / 10 % 10;
    int digit5 = num % 10;
    if (digit1 == digit5 && digit2 == digit4) return true;
    return false;
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    bool result = Polindrome(number);
    Console.Write($"Число {number} является палиндромом? ");
    if (result) Console.Write("ДА, является");
    else Console.Write("НЕТ, не является");
}
else 
    Console.Write("Вы ввели не пятизначное число. ");