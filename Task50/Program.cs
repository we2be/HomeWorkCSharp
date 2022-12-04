// Задача 50. Напишите программу, которая 
// на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Write("Введите значение строки двумерного массива : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение столбца двумерного массива : ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("]");
    }

}

int[,] randomMatrix = CreateMatrixRndInt(3, 4, 1, 10);
Console.WriteLine("Массив псевдослучайных чисел от 1 до 10");
PrintMatrix(randomMatrix);
Console.WriteLine("");
if (randomMatrix.GetLength(0) < m || randomMatrix.GetLength(1) < n) Console.WriteLine($"{m}, {n} -> такого элемента в массиве нет");
else Console.WriteLine($"Элемент массива ({m},{n}) равен {randomMatrix[m - 1, n - 1]}");