// Задача 21 
// Напишите программу, которая принимает 
// на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double GetDist(int x1, int x2, int y1, int y2, int z1, int z2) 
{
    double d = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
    d = Math.Round(d, 2, MidpointRounding.ToZero);
    return d;
}

Console.WriteLine("Введите координаты точки А:");
Console.Write("Х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.Write("Х: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double res = GetDist(x1, x2, y1, y2, z1, z2);
Console.WriteLine($"A ({x1},{y1},{z1}); B({x2},{y2},{z2})) расстояние между точками в 3D пространстве -> {res}");
