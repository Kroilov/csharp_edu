// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

using static System.Console;

int[,] GetArrayRandom(int m, int n)
{
    int[,] randomArray = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            randomArray[i, j] = new Random().Next(0, 10);
        }
    }
    return randomArray;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]}\t");
        }
        WriteLine();
    }
}

void MultiplyMatrix(int[,] arrayA, int[,] arrayB, int[,] arrayAB)
{
    for (int i = 0; i < arrayAB.GetLength(0); i++)
    {
        for (int j = 0; j < arrayAB.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                sum += arrayA[i, k] * arrayB[k, j];
            }
            arrayAB[i, j] = sum;
        }
    }
}

// количество строк второй матрицы должно быть равно количеству столбцов первой

Clear();
int[,] arrayA = GetArrayRandom(5, 5);
int[,] arrayB = GetArrayRandom(arrayA.GetLength(1), 5);
int[,] arrayAB = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

WriteLine($"Generated matrix A:");
PrintArray(arrayA);
WriteLine($"\nGenerated matrix B:");
PrintArray(arrayB);
MultiplyMatrix(arrayA, arrayB, arrayAB);
WriteLine($"\nResult of matrix multiplication:");
PrintArray(arrayAB);