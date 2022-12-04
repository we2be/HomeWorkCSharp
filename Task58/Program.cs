// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Программа находит произведение двух матриц.");
Console.Write("Введите количество строк матрицы A : ");
int rowA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы A : ");
int colA= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк матрицы B : ");
int rowB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы B : ");
int colB = Convert.ToInt32(Console.ReadLine());


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

int[,] MultiplicationMatrixIntAB(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixAB = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    int value = 0;

    for (int j = 0; j < matrixB.GetLength(1); j++)  //столбец
    {
        for (int i = 0; i < matrixA.GetLength(0); i++) //строка
        {
            for (int k = 0; k < matrixA.GetLength(1); k++) 
            {
                value += matrixA[i,k]*matrixB[k,j];
                //Console.WriteLine($"A[{i},{k}]->{matrixA[i,k]} * B[{k},{j}]->{matrixB[k,j]}");
            } 
            //Console.WriteLine($"C[{i},{j}]->{value}");
            matrixAB[i,j] = value;
            value = 0;  
        }
    }
    return matrixAB;
}

while (colA != rowB || colA < 1 || colB < 1 || rowA < 1 || rowB < 1) 
{
    if (colA < 1 || colB < 1 || rowA < 1 || rowB < 1) 
    {
        Console.WriteLine("Ошибка! Значения не могут быть отрицательными или 0.");
    }
    else 
    {
        Console.WriteLine("Ошибка! Матрицу А можно умножить на матрицу В только в том случае," 
        + "если число столбцов матрицы А равняется числу строк матрицы В!");
    }
    Console.WriteLine("Повторите ввод.");
    Console.Write("Количество строк матрицы A : ");
    rowA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Кколичество столбцов матрицы A : ");
    colA= Convert.ToInt32(Console.ReadLine());
    Console.Write("Количество строк матрицы B : ");
    rowB = Convert.ToInt32(Console.ReadLine());
    Console.Write("Количество столбцов матрицы B : ");
    colB = Convert.ToInt32(Console.ReadLine());
}    
int[,] newMatrixRndIntA = CreateMatrixRndInt(rowA, colA, 1, 5);
Console.WriteLine("матрица A заполненная случайными целыми числами");
PrintMatrix(newMatrixRndIntA);
int[,] newMatrixRndIntB = CreateMatrixRndInt(rowB, colB, 1, 5);
Console.WriteLine("матрица B заполненная случайными целыми числами");
PrintMatrix(newMatrixRndIntB);
int[,] multiplicationMatrixIntAB = MultiplicationMatrixIntAB(newMatrixRndIntA, newMatrixRndIntB);
Console.WriteLine("произведение матрицы А на B, матрица C");
PrintMatrix(multiplicationMatrixIntAB);