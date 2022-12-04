// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк двумерного массива : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент массива : ");
int minNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива : ");
int maxNum = Convert.ToInt32(Console.ReadLine());

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

double[] ArithmeticMeanElementsInColumns(int[,] matrix)
{
    double arithmeticMean = 0;
    double[] array = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++) //столбец
    {
        for (int j = 0; j < matrix.GetLength(0); j++) //строка
        {
            arithmeticMean += matrix[j, i];
            // Console.WriteLine($"строка {j} столбец {i} -> {matrix[j,i]}");
        }
        arithmeticMean /= matrix.GetLength(0);
        array[i] = Math.Round(arithmeticMean, 1);
        arithmeticMean = 0;
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{Math.Round(array[i], 1),5}");
        if (i < array.Length - 1) Console.Write(" |");

    }
    Console.WriteLine(" ]");
}

int[,] newMatrixRndInt = CreateMatrixRndInt(m, n, minNum, maxNum);
Console.WriteLine();
Console.WriteLine("массив заполненный случайными целыми числами");
PrintMatrix(newMatrixRndInt);

double[] arithmeticMeanElementsInColumns = ArithmeticMeanElementsInColumns(newMatrixRndInt);
Console.WriteLine();
Console.WriteLine("среднее арифметическое элементов в каждом столбце");
PrintArray(arithmeticMeanElementsInColumns);