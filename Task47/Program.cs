// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк двумерного массива : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент массива : ");
int minNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива : ");
int maxNum = Convert.ToInt32(Console.ReadLine());

double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
        } 
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 5} |");
            else Console.Write($"{matrix[i,j],5}");
        }
        Console.WriteLine(" ]");
    }
}

double[,]newMatrixDouble = CreateMatrixRndDouble(m, n, minNum, maxNum);
Console.WriteLine();
Console.WriteLine("массив заполненный случайными вещественными числами");
PrintMatrix(newMatrixDouble);