// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.WriteLine("3х мерная матрица. Программа будет построчно выводить массив, добавляя индексы каждого элемента");
Console.Write("Введите количество X : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество Y : ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество Z : ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] CreateMatrix3dRndInt(int rows, int columns, int slices, int min, int max)
{
    int[,,] matrix = new int[rows, columns, slices];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {    
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max + 1);
            }
        }
    }
    return matrix;
}

void PrintMatrix3d(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {            
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                Console.Write($"{matrix[i, j, k], 5} ");
                if (j < matrix.GetLength(1) - 1 ) Console.Write(" |");
                else if (k < matrix.GetLength(2) - 1 ) Console.Write(" |");
            }
        }
        Console.WriteLine(" ]");
    }
}

void PrintElemXYZMatrix3D(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {        
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                Console.Write($"{matrix[i, j, k], 5}({i},{j},{k})");
            }
        }
        Console.WriteLine();
    }
}

int[,,] newMatrixRndInt3d = CreateMatrix3dRndInt(x, y, z, 1, 5);
Console.WriteLine("3х мерная матрица заполненная случайными целыми числами");
PrintMatrix3d(newMatrixRndInt3d);

Console.WriteLine("3х мерная матрица и индексы каждого элемента");
PrintElemXYZMatrix3D(newMatrixRndInt3d);