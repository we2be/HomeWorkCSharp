// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (num1>num2)
{
    max = num1;
}
else if (num1<num2)
{
    max = num2;
}
else if (num1==num2)
{
    max = num1;
}
Console.WriteLine();
Console.WriteLine("Максимальное число " + max);