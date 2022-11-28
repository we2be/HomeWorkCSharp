// Напишите программу, которая получает
// на вход трехзначное число
// выводит вторую цифру числа

int ShowSecondDigit(int num) 
{
    int secondDigit = num / 10 % 10;
    return secondDigit;
}

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number<0) number = Math.Abs(number);
if (number>99 && number<1000) 
{
    int secondDigit = ShowSecondDigit(number);
    Console.WriteLine($"Вторая цифра числа {secondDigit}.");
}
else Console.WriteLine("Вы ввели не трехзначное число");