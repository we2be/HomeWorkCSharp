// Напишите программу, которая
// вход число
// выводит 3 цифру числа или сообщает, что 3 цифры нет

int ShowThirdDigit(int num) 
{
    int thirdDigit = 0;
    while (num>999)
    {
        num = num/10;
    }
    if (num>99) thirdDigit = num % 10;
    return thirdDigit;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int thirdDigit = ShowThirdDigit(Math.Abs(number));
if (thirdDigit>0) Console.WriteLine($"Третья цифра этого числа: {thirdDigit}");
else Console.WriteLine("Третьей цифры в этом числе НЕТ.");