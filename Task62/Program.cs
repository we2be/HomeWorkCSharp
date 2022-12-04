// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



Console.WriteLine("Создадим квадратный массив, заполненый элементами по возрастанию спирально.");
Console.Write("Введите количество строк и столбцов двумерного массива : ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrix(int rows, int number)
{
    int cols = rows;
    int[,] matrix = new int[rows, cols];
    int expon = rows*cols;
    int stepRow = 0;
    int stepCol = 0;
    while (number <= expon)
    {
        for (int j = stepCol; j < cols-stepCol; j++)
        {
            matrix[stepRow, j] = number++;   
        }
        for (int i = stepRow+1; i < rows-stepRow; i++)
        {
            matrix[i, cols-1-stepCol] = number++;
        }
        for (int j = cols-2-stepCol; j >= stepCol; j--)
        {
            matrix[rows-1-stepRow, j] = number++;
        }
        for (int i = rows-2-stepRow; i > stepRow; i--)
        {
            matrix[i, stepCol] = number++; 
        }
        stepRow++;
        stepCol++;
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

int[,] newMatrix = CreateMatrix(m, 1);
Console.WriteLine("массив заполненный случайными целыми числами");
PrintMatrix(newMatrix);