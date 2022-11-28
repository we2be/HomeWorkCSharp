// Напишете программу, которая
// на вход принимает число дня недели
// на выходе проверяет явлеется день выходным

bool DayOfWeek(int digit)
{
    if(digit==6 || digit==7) return true; 
    return false; 
}

Console.Write("Введите число дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if ( day > 0 && day < 8 ) 
{
    bool result = DayOfWeek(day);
    Console.WriteLine("День недели выходной?");
    if (result) Console.WriteLine("ДА");
    else Console.WriteLine("НЕТ");
}
else  Console.WriteLine("Заданное число не соотвествует дню недели");