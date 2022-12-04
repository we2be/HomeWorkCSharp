// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк двумерного массива : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива : ");
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
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
            if (j < matrix.GetLength(1) - 1) Console.Write(" |");
        }
        Console.WriteLine(" ]");
    }
}

int[,] SortElementsMatrixMaxToMinInRow(int[,] matrix)
{
    int temp = default;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {            
            for (int k = 0; k < matrix.GetLength(1); k++)
            {  
                if (matrix[i, j] > matrix[i, k]) 
                { 
                    temp = matrix[i, k];   
                    matrix[i, k] = matrix[i, j];
                    matrix[i, j] = temp; 
                }
            }                
        }
    } 
    return matrix;
}

int[,] newMatrixRndInt = CreateMatrixRndInt(m, n, 1, 100);
Console.WriteLine("массив заполненный случайными целыми числами");
PrintMatrix(newMatrixRndInt);
Console.WriteLine("массив измененнный");
int[,] sortElementsMatrixMaxToMinInRow = SortElementsMatrixMaxToMinInRow(newMatrixRndInt);
PrintMatrix(sortElementsMatrixMaxToMinInRow);